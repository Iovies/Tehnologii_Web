using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SMCS.BusinessLogic.Interfaces;
using SMCS.Web.Models.Auth;
using System.Security.Claims;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class AuthController : Controller
    {
        private readonly IServicesManager _servicesManager;

        public AuthController(IServicesManager manager)
        {
            _servicesManager = manager;
        }

        [HttpPost]
        [Route("auth/login")]
        public ActionResult LogIn(LogInViewModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isValid = _servicesManager.UserService.AuthenticateUser(loginModel.Username, loginModel.Password);
            if (isValid)
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, loginModel.Username),
                    new Claim(ClaimTypes.Name, loginModel.Username),
                }, "SMCS_Cookie");

                Request.HttpContext.SignInAsync(new ClaimsPrincipal(identity));

                return Redirect(Url.Action("index", "dashboard"));
            }

            ModelState.AddModelError("", "Invalid credentials");
            return View();
        }

        [HttpGet]
        [Route("auth/login")]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [Route("auth/register")]
        public ActionResult SignUp(RegisterViewModel registerView)
        {
            if (!ModelState.IsValid)
            {

            }
            return View();
        }

        [HttpGet]
        [Route("auth/register")]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("auth/logout")]
        public ActionResult LogOut()
        {
            return View();
        }
    }
}
