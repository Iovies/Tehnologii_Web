using SMCS.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCS.Models.Models
{
    public class TicketDbModel
    {
        [Key]
        public Guid ID { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string TicketTitle { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string TicketDescription { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string Location { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string ContactInfo { get; set; }

        [Required]
        public TicketStatusEnum TicketStatus { get; set; }
        
        [Required]
        public TicketPriorityEnum TicketPriority { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [DefaultValue(null)]
        public DateTime Closed { get; set; }

        [ForeignKey("OpenById")]
        public UserDbModel OpenBy { get; set; }

        [ForeignKey("AlocatedToId")]
        public virtual ICollection<UserDbModel> AlocatedTo { get; set; }
    }
}
