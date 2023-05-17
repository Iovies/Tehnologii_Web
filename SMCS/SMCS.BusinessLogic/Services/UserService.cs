using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Helpers;
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

        public bool AuthenticateUser(string username, string password)
        {
            var user = _unitOfWork.Users.GetByUsername(username);
            if (user == null) return false;
            return HashPasswordHelper.VerifyPassword(password, user.PasswordHash);
        }
    }
}
