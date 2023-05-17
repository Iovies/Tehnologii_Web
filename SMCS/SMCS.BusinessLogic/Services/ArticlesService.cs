using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Services
{
    public class ArticlesService : IArticlesService
    {
        public ArticlesService(IUnitOfWork unitOfWork)
        {
        }
    }
}
