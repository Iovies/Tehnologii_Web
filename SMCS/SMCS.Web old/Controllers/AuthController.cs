using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCS.Web.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        // GET: Auth/Login
        public ActionResult Login()
        {
            return View();
        }
        // GET: Auth/Register
        public ActionResult Register()
        {
            return View();
        }
    }
}