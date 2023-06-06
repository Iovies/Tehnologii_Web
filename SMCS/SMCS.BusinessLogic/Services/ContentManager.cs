using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Services
{
    public class ContentManager : IContentManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string GetContent(Guid path)
        {
            return _unitOfWork.ContentTrackers.Find(x => x.Id == path).Select(x=>x.LacalPath).FirstOrDefault();
        }

        public string GetFileHref(Guid guid)
        {
            return _unitOfWork.ContentTrackers.Find(x => x.Id == guid).Select(x => x.Href).FirstOrDefault();
        }

        public string GetFileName(Guid guid)
        {
            return _unitOfWork.ContentTrackers.Find(x => x.Id == guid).Select(x => x.Name).FirstOrDefault();
        }

        public void SetContent(Guid path, string content, string href, string filename)
        {
            _unitOfWork.ContentTrackers.Add(new ContentTrackerDbModel { Id = path, Href= href,LacalPath = content,Name = filename, Uploaded = DateTime.Now });
            _unitOfWork.Complete();
        }
    }
}
