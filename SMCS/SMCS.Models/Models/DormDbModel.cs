using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Models
{
    public class DormDbModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Dorm name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Dorm address")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Dorm phone number")]
        public string Phone { get; set; }

        [ForeignKey("AdministratorID")]
        public UserDbModel Administrator { get; set; }

        public virtual ICollection<FloorDbModel> Floors { get; set; }
    }
}
