using Microsoft.EntityFrameworkCore;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Data.DataAccess.Repositories;
using SMCS.Data.DataBaseContext;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TicketRepository : Repository<TicketDbModel>, ITicketRepository
    {
        public AppDataBaseContext appContext
        {
            get
            {
                return _context as AppDataBaseContext;
            }
        }

        public TicketRepository(AppDataBaseContext context) : base(context)
        {

        }

        public ILookup<DateTime,TicketDbModel> GetTicketsGroupedByDate()
        {
            return appContext.Tickets.ToLookup(x => x.Created.Date);
        }

    }
}
