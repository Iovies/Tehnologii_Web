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
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }

        public TicketRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<IGrouping<DateTime, TicketDbModel>> GetTicketsGroupedByDate()
        {
            return appContext.Tickets.GroupBy(t => t.Created.Date).AsEnumerable();
        }

        public IEnumerable<TicketDbModel> GetTicketPagination(int count, int page)
        {
            return appContext.Tickets.Skip((page - 1) * count).Take(count);
        }
    }
}
