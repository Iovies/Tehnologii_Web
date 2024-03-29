﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Models
{
    public class UserDbModel : IdentityUser
    {
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
        public DateTime BirthDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Faculty")]
        public string Faculty { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Speciality")]
        public string Speciality { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Group")]
        public string Group { get; set; }

        [DefaultValue(false)]
        public bool HasProfilePic { get; set; }

        [DefaultValue(null)]
        public Guid ProfilePicID { get; set; }
    }
}
