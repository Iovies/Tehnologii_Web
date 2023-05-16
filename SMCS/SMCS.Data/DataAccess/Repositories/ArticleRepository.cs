using Microsoft.EntityFrameworkCore;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Data.DataAccess.Repositories;
using SMCS.Data.DataBaseContext;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ArticleRepository : Repository<ArticleDbModel>, IArticleRepository
    {
        public AppDataBaseContext appContext
        {
            get
            {
                return _context as AppDataBaseContext;
            }
        }

        public ArticleRepository(AppDataBaseContext context) : base(context)
        {

        }

        public int GetLikes(Guid ID)
        {
            return appContext.Articles.Where(x => x.ID == ID).Select(x => x.Likes).FirstOrDefault();
        }
    }
}
