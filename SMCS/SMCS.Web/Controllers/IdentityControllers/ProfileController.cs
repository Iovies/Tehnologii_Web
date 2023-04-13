using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class ProfileController : SMCSController
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }
    }
}