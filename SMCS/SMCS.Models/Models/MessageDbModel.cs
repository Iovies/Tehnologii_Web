using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCS.Models.Models
{
    public class MessageDbModel
    {
        [Key]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(256, ErrorMessage = "Message can not be longer than 256 characters")]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime Sent { get; set; }

        [ForeignKey("SenderID")]
        public UserDbModel Sender { get; set; }

        [ForeignKey("ChatID")]
        public ChatDbModel Chat { get; set; }
    }
}