using FinalProject_ZPloy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.Interfaces
{
    public interface IBidService
    {
        public IEnumerable<UserBidOnTask> GetAllBids();
        public void CreateBid(UserBidOnTask bid);
        public void ApproveBid(UserBidOnTask bid);
        public void RejectBid(UserBidOnTask bid);
        public UserBidOnTask GetBid(int id);
        public bool CheckWhetherUserAppliedForTheTask(int userId,int taskId);
        public List<int> GetListOfTasksUserHasAppliedFor(int userId);

    }
}
