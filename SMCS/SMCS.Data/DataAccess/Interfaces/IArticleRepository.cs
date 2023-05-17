using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Interfaces
{
    public interface IArticleRepository : IRepository<ArticleDbModel>
    {
        int GetLikes(Guid ID);
    }
}
