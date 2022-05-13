﻿// <auto-generated />
using System;
using FinalProject_ZPloy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject_ZPloy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220513194919_testt3")]
    partial class testt3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject_ZPloy.Models.Inbox", b =>
                {
                    b.Property<int>("InboxID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("InboxID");

                    b.HasIndex("UserID");

                    b.ToTable("Inboxes");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InboxID")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationID");

                    b.HasIndex("InboxID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Task", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatorID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PerformerID")
                        .HasColumnType("int");

                    b.Property<int>("Prize")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDone")
                        .HasColumnType("bit");

                    b.HasKey("TaskID");

                    b.HasIndex("CreatorID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Inbox", b =>
                {
                    b.HasOne("FinalProject_ZPloy.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Notification", b =>
                {
                    b.HasOne("FinalProject_ZPloy.Models.Inbox", null)
                        .WithMany("Notifications")
                        .HasForeignKey("InboxID");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Task", b =>
                {
                    b.HasOne("FinalProject_ZPloy.Models.User", "User")
                        .WithMany("CompletedTasks")
                        .HasForeignKey("CreatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.Inbox", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("FinalProject_ZPloy.Models.User", b =>
                {
                    b.Navigation("CompletedTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
