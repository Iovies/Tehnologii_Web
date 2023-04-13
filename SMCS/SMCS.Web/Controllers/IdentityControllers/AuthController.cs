using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SMCS.Web.Models.Auth;
using System.Security.Claims;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class AuthController : SMCSController
    {
        [HttpPost]
        [Route("auth/LogIn")]
        public ActionResult LogIn(LogInViewModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //var isValid = _usersService.AuthenticateUser(loginModel);
            //if (isValid)
            //{
            //    var identity = new ClaimsIdentity(new[]
            //    {
            //        new Claim(ClaimTypes.NameIdentifier, loginModel.Username),
            //        new Claim(ClaimTypes.Name, loginModel.Username),
            //    }, DefaultAuthenticationTypes.ApplicationCookie);

            //    Request.GetOwinContext().Authentication.SignIn(new AuthenticationProperties() { IsPersistent = false }, identity);

            //    return Redirect(GetRedirectUrl(loginModel.ReturnUrl));
            //}

            ModelState.AddModelError("", "Invalid credentials");
            return View();
        }
        [HttpGet]
        [Route("auth/LogIn")]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpGet]
        [Route("auth/SignUp")]
        public ActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //[Route("auth/SignOut")]
        //public ActionResult SignOut()
        //{
        //    return View();
        //}
    }
}
