using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class AuthController : SMCSController
    {
        [HttpPost]
        [Route("auth/LogIn")]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [Route("auth/SignOut")]
        public ActionResult SignOut()
        {
            return View();
        }

    }
}