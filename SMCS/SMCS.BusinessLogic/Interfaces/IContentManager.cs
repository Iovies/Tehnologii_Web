using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Interfaces
{
    public interface IContentManager
    {
        string GetContent(Guid path);
        void SetContent(Guid path, string content,string href, string filename);
        string GetFileName(Guid guid);
        string GetFileHref(Guid guid);
    }
}
