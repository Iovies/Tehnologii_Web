using SMCS.Data.DataAcces.Interfaces;
using SMCS.Data.DataBaseContext;
using SMCS.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAcces.Repositories.TicketRepositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDataBaseContext _context;

        public TicketRepository(AppDataBaseContext context)
        {
            _context = context;
        }

        public List<TicketDTO> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        public TicketDTO GetTicketById(Guid id)
        {
            return _context.Tickets.FirstOrDefault(t => t.ID == id);
        }

        public void AddTicket(TicketDTO ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public void UpdateTicket(TicketDTO ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTicket(Guid id)
        {
            var ticket = _context.Tickets.Find(id);
            _context.Tickets.Remove(ticket);
            _context.SaveChanges();
        }
    }
    }
