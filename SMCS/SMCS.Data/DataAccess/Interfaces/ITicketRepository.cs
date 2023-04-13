using SMCS.Data.DataBaseContext;
using SMCS.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAcces.Interfaces
{
    public interface ITicketRepository
    {
        List<TicketDTO> GetAllTickets();
        TicketDTO GetTicketById(Guid id);
        void AddTicket(TicketDTO ticket);
        void UpdateTicket(TicketDTO ticket);
        void DeleteTicket(Guid id);
    }
}
