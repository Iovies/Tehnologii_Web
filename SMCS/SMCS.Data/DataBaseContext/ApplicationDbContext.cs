using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Options;
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
    public class ApplicationDbContext : IdentityDbContext<UserDbModel>
    {
        public DbSet<TicketDbModel> Tickets { get; set; }
        public DbSet<ArticleDbModel> Articles { get; set; }
        public DbSet<ImageDbModel> ArticleImages { get; set; }
        public DbSet<DormDbModel> Dorms { get; set; }
        public DbSet<FloorDbModel> Floors { get; set; }
        public DbSet<RoomDbModel> Rooms { get; set; }
        public DbSet<ChatDbModel> Chats { get; set; }
        public DbSet<MessageDbModel> Messages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
