using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.EFServices
{
    public class EFBidService : IBidService
    {
        private AppDbContext context;

        public EFBidService(AppDbContext contextService)
        {
            context = contextService;
        }

        public IEnumerable<UserBidOnTask> GetAllBids()
        {
            return context.UserBids;   
        }

        public void CreateBid(UserBidOnTask bid)
        {
            context.UserBids.Add(bid);
            context.SaveChanges();
        }

        public void ApproveBid(UserBidOnTask bid)
        {
            bid.isAccepted = true;
            context.UserBids.Update(bid);
            context.SaveChanges();                                                                                                                             
        }
         
        public void RejectBid(UserBidOnTask bid)
        {
            bid.isAccepted = false;
            context.UserBids.Update(bid);
            context.SaveChanges();
        }

        public UserBidOnTask GetBid(int id)
        {
            return context.UserBids.Where(t => t.BidID == id).FirstOrDefault(t => t.BidID == id);
        }
        //public bool CheckWhetherUserAppliedForTheTask(int userId, int taskId)
        //{
        //    int noOfElements = context.UserBids.Where(t => t.UserID == userId).Count();
        //    if (noOfElements == 1)
        //    {
        //        int taskID = Bids.Where(t => t.UserID == userId).FirstOrDefault(t => t.BidID == userId).TaskID;
        //        if (taskId == taskID)
        //        {
        //            return true;
        //        }
        //        else if (noOfElements > 1)
        //        {
        //            while(noOfElements > 0)
        //            {
        //                taskID = Bids.Where(t => t.UserID == userId).FirstOrDefault(t => t.BidID == userId).TaskID;
        //                if (taskId == taskID)
        //                {
        //                    Bids.Remove(Bids.Where(t => t.UserID == userId).FirstOrDefault(t => t.BidID == userId));
        //                    return true;
        //                }
        //            }
        //            return true;
        //        }
        //        else return false;
        //    }
        //    else return false;

        //}
        public List<int> GetListOfTasksUserHasAppliedFor(int userId)
        {
            List<UserBidOnTask> userBids = context.UserBids.Where(t => t.UserID == userId).ToList();
            List<int> tasks = new List<int>();
            foreach(var bid in userBids)
            {
                tasks.Add(bid.TaskID);
            }
            return tasks;
        }

        public bool CheckWhetherUserAppliedForTheTask(int userId, int taskId)
        {
            List<int> tasks = GetListOfTasksUserHasAppliedFor(userId);
            if (tasks.Contains(taskId))
            {
                return true;
            }
            else return false;
        }
    }
}
