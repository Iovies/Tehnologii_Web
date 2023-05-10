using Microsoft.AspNetCore.Mvc;
using SMCS.Web.Models.Lodging;

namespace SMCS.Web.Controllers.LodgingControllers
{
    public class LodgingController : Controller
    {
        public IActionResult Index()
        {
            var model = new LodgingInfoModel();
            model.Dorms = new List<string>()
            {
                "Camin 1 str...",
                "Camin 2 str...",
                "Camin 3 str...",
                "Camin 4 str...",
                "Camin 5 str...",
                "Camin 6 str...",
                "Camin 7 str...",
                "Camin 8 str..."
            };
            model.CellmatesCount = 4;
            return View(model);
        }
    }
}
