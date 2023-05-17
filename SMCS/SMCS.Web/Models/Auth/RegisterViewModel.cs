using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMCS.Web.Models.Auth
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 5)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Patronymic")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(1, MinimumLength = 1)]
        [DisplayName("ID Card Series")]
        public char IDCardSeries { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(8, MinimumLength = 8)]
        [DisplayName("ID Card Number")]
        public string IDCardNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(13, MinimumLength = 13)]
        [DisplayName("IDNP")]
        public string IDNP { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayName("Birth Date")]
        public DateOnly BirthDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the password!")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8)]
        [RegularExpression(@"^([a-zA-Z0-9]{8,15})$", ErrorMessage = "Password must contain: " +
            "Minimum 8 characters atleast 1 UpperCase Alphabet, " +
            "1 LowerCase      Alphabet and 1 Number")]
        [DisplayName("Password")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Faculty")]
        public string Faculty { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Speciality")]
        public string Speciality { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Group")]
        public string Group { get; set; }
    }
}
