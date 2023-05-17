using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.DocumentationControllers
{
    public class DocumentationController : Controller
    {
        [HttpGet]
        [Route("docs")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
