using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCS.Web.Controllers.TicketControllers
{
    public class TicketController : SMCSController
    {
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }
    }
}