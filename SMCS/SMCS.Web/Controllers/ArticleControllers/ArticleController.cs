using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.ArticleControllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        [Route("Articles")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
