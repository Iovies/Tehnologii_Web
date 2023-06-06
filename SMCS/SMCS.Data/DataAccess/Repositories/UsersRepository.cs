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
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }

        public UsersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public UserDbModel GetByUsername(string username)
        {
            return (UserDbModel)appContext.Users.FirstOrDefault(u => u.UserName == username);
        }

        public Guid GetIDByUsername(string username)
        {
            return Guid.Parse(appContext.Users.FirstOrDefault(u => u.UserName == username).Id);
        }

        public UserDbModel Get(string id)
        {
            return appContext.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
