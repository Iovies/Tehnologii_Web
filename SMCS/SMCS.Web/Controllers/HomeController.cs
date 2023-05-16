using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SMCS.Web.Models;
using System.Diagnostics;

namespace SMCS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult ToggleStyle()
        {
            string selectedStyle = "default";

            if (Request.Cookies["SelectedStyle"] != null)
            {
                selectedStyle = Request.Cookies["SelectedStyle"];
            }

            // Toggle the selected style
            if (selectedStyle == "default")
            {
                selectedStyle = "dark";
            }
            else
            {
                selectedStyle = "default";
            }

            // Set the cookie with the updated style
            Response.Cookies.Append("SelectedStyle", selectedStyle, new CookieOptions
            {
                Path = "/", // Set the path to root ("/") to make the cookie accessible across different pages
                            // Additional cookie options if needed
                            // For example, you can set the cookie expiration, domain, etc.
            });

            return Ok(); // Return a successful response
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string selectedStyle;

            if (Request.Cookies["SelectedStyle"] != null)
            {
                selectedStyle = Request.Cookies["SelectedStyle"];
            }
            else
            {
                selectedStyle = "default";
            }

            ViewBag.SelectedStyle = selectedStyle;

            base.OnActionExecuting(filterContext);
        }
    }
}