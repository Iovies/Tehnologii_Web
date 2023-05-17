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
    public class UsersRepository : Repository<UserDbModel>, IUsersRepository
    {
        public AppDataBaseContext appContext
        {
            get
            {
                return _context as AppDataBaseContext;
            }
        }

        public UsersRepository(AppDataBaseContext context) : base(context)
        {
        }

        public UserDbModel GetByUsername(string username)
        {
            var user = appContext.Users.FirstOrDefault(u => u.Email == username);
            if (user == null)
                return null;
            return (UserDbModel)user;
        }

    }
}
