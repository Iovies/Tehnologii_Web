using SMCS.Data.DataAccess.Interfaces;
using SMCS.Data.DataBaseContext;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Interfaces
{
    public interface ITicketRepository : IRepository<TicketDbModel>
    {
        public ILookup<DateTime, TicketDbModel> GetTicketsGroupedByDate();
    }
}
