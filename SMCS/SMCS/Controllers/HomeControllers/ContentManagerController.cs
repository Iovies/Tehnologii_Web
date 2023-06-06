using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMCS.BusinessLogic.Interfaces;
using SMCS.Models.Models;

namespace SMCS.Controllers.HomeControllers
{
    public class ContentManagerController : Controller
    {
        private readonly IContentManager _contentManager;

        public ContentManagerController(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        [HttpGet]
        public IActionResult Get(Guid id)
        {
            var file = _contentManager.GetContent(id);

            if (file == null)
            {
                return NotFound();
            }

            var fileName = _contentManager.GetFileName(id);

            return File(System.IO.File.OpenRead(file), "application/octet-stream", fileName);
        }
        [HttpGet]
        public IActionResult GetHref(Guid id)
        {
            var file = _contentManager.GetContent(id);

            if (file == null)
            {
                return NotFound();
            }

            var fileName = _contentManager.GetFileHref(id);

            return Ok(fileName);
        }

        [HttpPost]
        public IActionResult Load(IFormFile file)
        {
            if (file == null)
            {
                return BadRequest("File is null.");
            }

            var fileId = Guid.NewGuid();
            var fileName = fileId.ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imgs\\SMCS", fileName);
            var href = "/imgs/SMCS/" + fileName;

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            
            _contentManager.SetContent(fileId, filePath, href, file.FileName);

            return Ok(fileId);
        }

    }
}
