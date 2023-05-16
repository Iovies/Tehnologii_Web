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
        public AppDataBaseContext appContext
        {
            get
            {
                return _context as AppDataBaseContext;
            }
        }

        public RoomRepository(AppDataBaseContext context) : base(context)
        {

        }
    }
}
