using SMCS.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataBaseContext
{
    public class AppDataBaseContext : DbContext
    {
        public AppDataBaseContext() : base("DefaultConnection")
        {
        }
        public DbSet<TicketDTO> Tickets { get; set; }
    }
}
