using Microsoft.EntityFrameworkCore;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Data.DataAccess.Repositories;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Repositories
{
    public class FloorRepository : Repository<FloorDbModel>, IFloorRepository
    {
        public FloorRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
