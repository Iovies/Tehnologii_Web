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
    public class RoomRepository : Repository<RoomDbModel>, IRoomRepository
    {
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }

        public RoomRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
