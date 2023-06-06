using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Guid GetIDByUsername(string username)
        {
            return _unitOfWork.Users.GetIDByUsername(username);
        }
        public UserDbModel Get(Guid id)
        {
            return _unitOfWork.Users.Get(id);
        }
        public UserDbModel Get(string id)
        {
            return _unitOfWork.Users.Get(id);
        }
    }
}
