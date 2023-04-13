using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class RoleController : SMCSController
    {
        // GET: Role
        public ActionResult Index()
        {
            return View();
        }
    }
}