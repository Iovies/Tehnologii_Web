using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.ArticleControllers
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
