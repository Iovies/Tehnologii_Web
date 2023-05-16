using Microsoft.AspNetCore.Mvc;
using SMCS.Domains.Entities;
using SMCS.Web.Models.Lodging;

namespace SMCS.Web.Controllers.LodgingControllers
{
    public class LodgingController : Controller
    {
        [HttpGet]
        [Route("lodging")]
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

        [HttpGet]
        [Route("lodging/requests")] // Only admin
        public IActionResult ViewRequests()
        {
            var model = new RequestModel();
            model.requestModels = new List<LodgingRequestModel>()
            {
                new LodgingRequestModel() { ID = "1234", Name="Alex", Description = "Salut"},
                new LodgingRequestModel() { ID = "231", Name="Alex Pro", Description = "Buna"},
                new LodgingRequestModel() { ID = "6543", Name="Alex Pro Max", Description = "Buna ziua"},
                new LodgingRequestModel() { ID = "1096", Name="Alex Pro Max S", Description = "Buna Dimineata"},
                new LodgingRequestModel() { ID = "32435", Name="Alex Pro Max XS", Description = "Buna ZIUA?"},
                new LodgingRequestModel() { ID = "111", Name="Alex Pro Max XXL", Description = "DA?!"}
            };
           
            return View(model);
        }

        [HttpGet]
        [Route("lodging/requests/{id}")] // Only admin
        public IActionResult ViewRequest(LodgingRequestModel model)
        {
            return View(model);
        }
    }
}
