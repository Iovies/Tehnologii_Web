using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.ArticleControllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
