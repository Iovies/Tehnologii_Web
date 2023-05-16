using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Models
{
    public class RoleDbModel
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Role Name")]
        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public DateTime Created { get; set; }

        public ICollection<ClaimsDbModel> RoleClaims { get; set; }
    }
}
