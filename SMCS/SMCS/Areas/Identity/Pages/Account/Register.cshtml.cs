// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using SMCS.Models.Models;

namespace SMCS.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<UserDbModel> _signInManager;
        private readonly UserManager<UserDbModel> _userManager;
        private readonly IUserStore<UserDbModel> _userStore;
        private readonly ILogger<RegisterModel> _logger;

        public RegisterModel(
            UserManager<UserDbModel> userManager,
            IUserStore<UserDbModel> userStore,
            SignInManager<UserDbModel> signInManager,
            ILogger<RegisterModel> logger//,
            )
        {
            _userManager = userManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(AllowEmptyStrings = false)]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(AllowEmptyStrings = false)]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(5, ErrorMessage = "Username must be at least 5 characters long")]
            [Display(Name = "Username")]
            public string UserName { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(3, ErrorMessage = "First name must be at least 3 characters long")]
            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(3, ErrorMessage = "Last name must be at least 3 characters long")]
            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(3, ErrorMessage = "Patronymic must be at least 3 characters long")]
            [Display(Name = "Patronymic")]
            public string Patronymic { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(1, ErrorMessage = "ID Card Series must be at least 1 character long")]
            [MaxLength(1, ErrorMessage = "ID Card Series must be no more than 1 character long")]
            [Display(Name = "ID Card Series")]
            public string IDCardSeries { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(8, ErrorMessage = "ID Card Number must be at least 8 characters long")]
            [MaxLength(8, ErrorMessage = "ID Card Number must be no more than 8 characters long")]
            [Display(Name = "ID Card Number")]
            public string IDCardNumber { get; set; }
            
            [Required(AllowEmptyStrings = false)]
            [MinLength(13, ErrorMessage = "IDNP must be at least 13 characters long")]
            [MaxLength(13, ErrorMessage = "IDNP must be no more than 13 characters long")]
            [Display(Name = "IDNP")]
            public string IDNP { get; set; }
            
            [Required(AllowEmptyStrings = false)]
            [Display(Name = "Phone number")]
            [DataType(DataType.PhoneNumber)]
            [Phone]
            public string PhoneNumber { get; set; }

            [Required(AllowEmptyStrings = false)]
            [Display(Name = "Birth date")]
            public DateTime BirthDate { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(2, ErrorMessage = "Faculty must be at least 2 characters long")]
            [Display(Name = "Faculty")]
            public string Faculty { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(2, ErrorMessage = "Speciality must be at least 2 characters long")]
            [Display(Name = "Speciality")]
            public string Speciality { get; set; }

            [Required(AllowEmptyStrings = false)]
            [MinLength(2, ErrorMessage = "Group must be at least 2 characters long")]
            [Display(Name = "Group")]
            public string Group { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private UserDbModel CreateUser()
        {
            try
            {
                var newUser = Activator.CreateInstance<UserDbModel>();
                newUser.UserName = Input.UserName;
                newUser.Email = Input.Email;
                newUser.FirstName = Input.FirstName;
                newUser.LastName = Input.LastName;
                newUser.Patronymic = Input.Patronymic;
                newUser.IDCardSeries = Input.IDCardSeries[0];
                newUser.IDCardNumber = Input.IDCardNumber;
                newUser.IDNP = Input.IDNP;
                newUser.PhoneNumber = Input.PhoneNumber;
                newUser.BirthDate = Input.BirthDate;
                newUser.Faculty = Input.Faculty;
                newUser.Speciality = Input.Speciality;
                newUser.Group = Input.Group;
                return newUser;
                //return Activator.CreateInstance<UserDbModel>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(UserDbModel)}'. " +
                    $"Ensure that '{nameof(UserDbModel)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
    }
}
