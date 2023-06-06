using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Interfaces
{
    public interface ITicketsService
    {
        public IEnumerable<IGrouping<DateTime, TicketDbModel>> GetTicketsGroupedByDate();
        public IEnumerable<TicketDbModel> GetTicketPagination(int count, int page);
        public TicketDbModel GetTicketById(Guid id);
    }
}
