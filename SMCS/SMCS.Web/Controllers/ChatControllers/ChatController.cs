using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.ChatControllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
