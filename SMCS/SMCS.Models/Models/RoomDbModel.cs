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
    public class RoomDbModel
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [Range(1,20)]
        [DisplayName("Room number")]
        public uint RoomNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Room name")]
        public string RoomName { get; set; }

        [Required]
        [StringLength(256)]
        [DisplayName("Room description")]
        public string Description { get; set; }

        [Required]
        [Range(1, 10)]
        [DisplayName("Room capacity")]
        public uint Capacity { get; set; }

        [Required]
        [Range(0, 10)]
        [DisplayName("Current occupancy")]
        public uint CurrentOccupancy { get; set; }

        [ForeignKey("ID")]
        public FloorDbModel Floor { get; set; }
    }
}
