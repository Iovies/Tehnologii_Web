using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Interfaces
{
    public interface IUsersRepository:IRepository<UserDbModel>
    {
        public UserDbModel GetByUsername(string username);
    }
}
