using Microsoft.AspNetCore.Mvc;

namespace SMCS.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        [Route("article")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
