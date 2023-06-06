using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Services
{
    public class TicketService : ITicketsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TicketService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public TicketDbModel GetTicketById(Guid id)
        {
            return (TicketDbModel)_unitOfWork.Tickets.Find(x => x.ID == id).FirstOrDefault();
        }

        public IEnumerable<TicketDbModel> GetTicketPagination(int count, int page)
        {
            return _unitOfWork.Tickets.GetTicketPagination(count, page);
        }

        public IEnumerable<IGrouping<DateTime, TicketDbModel>> GetTicketsGroupedByDate()
        {
            return _unitOfWork.Tickets.GetTicketsGroupedByDate();
        }
    }
}