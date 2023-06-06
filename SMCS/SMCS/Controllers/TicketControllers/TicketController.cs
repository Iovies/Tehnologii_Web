using Microsoft.AspNetCore.Mvc;
using SMCS.BusinessLogic.Interfaces;

namespace SMCS.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketsService _ticketsService;

        public TicketController(ITicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }

        [HttpGet]
        [Route("ticket")]
        public IActionResult Index()
        {
            var model = _ticketsService.GetTicketsGroupedByDate().OrderByDescending(x=>x.Key);
            return View(model);
        }
        [HttpGet]
        [Route("ticket/viewticket/{id}")]
        public IActionResult ViewTicket(Guid id)
        {
            var ticket = _ticketsService.GetTicketById(id);
            return View(ticket);
        }
    }
}
