using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.ArticleControllers
{
    public class ArticleController : SMCSController
    {
        [HttpGet]
        [Route("Articles")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
