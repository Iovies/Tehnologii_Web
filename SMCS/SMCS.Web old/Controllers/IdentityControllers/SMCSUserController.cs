using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class SMCSUserController : SMCSController
    {
        // GET: SMCSUser
        public ActionResult Index()
        {
            return View();
        }
    }
}