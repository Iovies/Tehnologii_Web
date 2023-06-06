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
    public class ContentTrackerRepository : Repository<ContentTrackerDbModel>, IContentTrackerRepository
    {
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }
        public ContentTrackerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
