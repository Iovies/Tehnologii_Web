using Microsoft.AspNetCore.Mvc;
using SMCS.Web.Models.Tickets;

namespace SMCS.Web.Controllers.TicketControllers
{
    public class TicketController : SMCSController
    {
        [HttpGet]
        [Route("ticket/index")]
        public IActionResult Index()
        {
            var model = new ViewTicketsViewModel();
            model.Tickets = new List<Ticket>()
            {
                new Ticket() {TicketNumber = "755636",TicketTitle="Test ticket" },
                new Ticket() {TicketNumber = "987498",TicketTitle="Other test ticket" },
                new Ticket() {TicketNumber = "812377",TicketTitle="Another test ticket" },
                new Ticket() {TicketNumber = "234552",TicketTitle="Some test ticket" },
                new Ticket() {TicketNumber = "328383",TicketTitle="New test ticket" },
            };
            return View(model);
        }
        [HttpGet]
        [Route("ticket/viewticket/{id}")]
        public IActionResult ViewTicket(int id)
        {
            return View(id);
        }
    }
}
