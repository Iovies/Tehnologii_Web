using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.DocumentationControllers
{
    public class DocumentationController : SMCSController
    {
        [HttpGet]
        [Route("docs")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
