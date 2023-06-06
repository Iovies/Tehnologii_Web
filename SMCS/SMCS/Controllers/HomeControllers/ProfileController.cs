using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;

namespace SMCS.Controllers.HomeControllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly IContentManager _contentManager;

        public ProfileController(IUserService userService, IContentManager contentManager)
        {
            _userService = userService;
            _contentManager = contentManager;
        }

        //profile pic
        public IActionResult GetUserAvatar(Guid userID)
        {
            if (userID == Guid.Empty)
            {
                return NotFound();
            }
            var userIdString = userID.ToString(); // Convert Guid to string
            var user = _userService.Get(userIdString);
            if (user == null)
            {
                return NotFound();
            }

            if (!user.HasProfilePic)
            {
                return NotFound();
            }

            var avatar = _contentManager.GetFileHref(user.ProfilePicID);
            if (avatar == null)
            {
                return NoContent();
            }

            return Ok(avatar);
        }


        public IActionResult GetUserID(string username)
        {
            if (username == null)
            {
                return NotFound();
            }
            var user = _userService.GetIDByUsername(username);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
