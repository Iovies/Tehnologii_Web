using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Interfaces
{
    public interface IUserService
    {
        public Guid GetIDByUsername(string username);
        public UserDbModel Get(Guid id);
        public UserDbModel Get(string id);
    }
}
