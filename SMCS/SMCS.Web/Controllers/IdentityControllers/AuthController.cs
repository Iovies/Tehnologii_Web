using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMCS.BusinessLogic.Interfaces;
using SMCS.Models.Models;
using SMCS.Web.Models.Auth;
using System.Security.Claims;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class AuthController : Controller
    {
        private readonly IServicesManager _servicesManager;
        private readonly SignInManager<UserDbModel> _signInManager;

        public AuthController(IServicesManager manager, SignInManager<UserDbModel> signInManager)
        {
            _servicesManager = manager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("auth/login")]
        public async Task<ActionResult> LogIn(LogInViewModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isValid = true;//= _servicesManager.UserService.AuthenticateUser(loginModel.Username, loginModel.Password);
            if (isValid)
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, loginModel.Username),
                    new Claim(ClaimTypes.Name, loginModel.Username),
                }, "SMCS_Cookie");

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1),
                    IsPersistent = true,
                    IssuedUtc = DateTimeOffset.UtcNow,
                };
                //var userDbModel = _servicesManager.UserService.GetUserByUsername(loginModel.Username);
                //var signInResult = await _signInManager.PasswordSignInAsync(userDbModel, loginModel.Password, false, lockoutOnFailure: false);

                //if (signInResult.Succeeded)
                //{
                //    await HttpContext.SignInAsync(new ClaimsPrincipal(identity), authProperties);

                //    return Redirect(Url.Action("index", "dashboard"));
                //}
            }

            ModelState.AddModelError("", "Invalid username or password");
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
                return View();
            }
            if (registerView.Password != registerView.ConfirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return View();
            }

            //var isSuccess = _servicesManager.UserService.RegisterUser
            //        (
            //            registerView.Username,
            //            registerView.Email,
            //            registerView.Password,
            //            registerView.FirstName,
            //            registerView.LastName,
            //            registerView.Patronymic,
            //            registerView.IDCardSeries,
            //            registerView.IDCardNumber,
            //            registerView.IDNP,
            //            registerView.PhoneNumber,
            //            registerView.BirthDate,
            //            registerView.Faculty,
            //            registerView.Speciality,
            //            registerView.Group
            //        );
            //if (isSuccess)
            //{
            //    return RedirectToAction("SuccesRegister");
            //}

            ModelState.AddModelError("", "There were some errors when creating the account, try again later");
            return View();
        }

        [HttpGet]
        [Route("auth/register")]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        [Route("auth/SuccesRegister")]
        public ActionResult SuccessRegister()
        {
            return View();
        }

        [HttpPost]
        [Route("auth/logout")]
        public ActionResult LogOut()
        {
            Request.HttpContext.SignOutAsync();
            return View();
        }
    }
}
