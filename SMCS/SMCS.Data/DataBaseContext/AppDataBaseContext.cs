using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Options;
using SMCS.Models.Helpers;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataBaseContext
{
    public class AppDataBaseContext : IdentityDbContext
    public class AppDataBaseContext : IdentityDbContext
    {
        public AppDataBaseContext(DbContextOptions<AppDataBaseContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<TicketDbModel> Tickets { get; set; }
        public DbSet<ArticleDbModel> Articles { get; set; }
        public DbSet<ImageDbModel> ArticleImages { get; set; }
        public DbSet<DormDbModel> Dorms { get; set; }
        public DbSet<FloorDbModel> Floors { get; set; }
        public DbSet<RoomDbModel> Rooms { get; set; }
        public DbSet<ChatDbModel> Chats { get; set; }
        public DbSet<MessageDbModel> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserDbModel>(
            //    builder =>
            //    {
            //        builder.HasData(
            //            new UserDbModel()
            //            {
            //                ID = Guid.NewGuid(),
            //                UserName = "admin",
            //                Email = "admin@admin",
            //                Password = HashPasswordHelper.HashPassword("password")
            //            });
            //        builder.ToTable("Users").HasKey(x => x.ID);
            //        builder.Property(x => x.ID).ValueGeneratedOnAdd();
            //    });
            //modelBuilder.Entity<RoleDbModel>(
            //    builder =>
            //    {
            //        builder.HasData(
            //            new RoleDbModel()
            //            {
            //                ID = Guid.NewGuid(),
            //                Name = "Admin"
            //            });
            //        builder.ToTable("Roles").HasKey(x => x.ID);
            //        builder.Property(x => x.ID).ValueGeneratedOnAdd();
            //    });
            base.OnModelCreating(modelBuilder);
        }
    }
}
