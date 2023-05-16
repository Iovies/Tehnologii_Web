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
    public class FloorDbModel
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [DisplayName("Floor number")]
        public uint FloorNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Floor name")]
        public string FloorName { get; set; }

        [StringLength(256, MinimumLength = 0)]
        [DisplayName("Floor description")]
        public string Description { get; set; }

        [ForeignKey("ID")]
        public DormDbModel Dorm { get; set; }

        public virtual ICollection<RoomDbModel> Rooms { get; set; }

    }
}
