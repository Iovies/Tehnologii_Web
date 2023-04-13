using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.TicketControllers
{
    public class TicketController : SMCSController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
