using Microsoft.EntityFrameworkCore;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Data.DataBaseContext;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Repositories
{
    public class DormRepository : Repository<DormDbModel>, IDormRepository
    {
        public AppDataBaseContext appContext
        {
            get
            {
                return _context as AppDataBaseContext;
            }
        }

        public DormRepository(AppDataBaseContext dbContext) : base(dbContext)
        {
        }
    }
}
