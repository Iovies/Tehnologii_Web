using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Models
{
    public class ChatDbModel
    {
        [Key]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(256)]
        public string Description { get; set; }

        [DefaultValue(false)]
        public bool HasThumbnail { get; set; }

        [DefaultValue(null)]
        public Guid Thumbnail { get; set; }

        public virtual ICollection<UserDbModel> Users { get; set; }
        public virtual ICollection<MessageDbModel> Messages { get; set; }
    }
}
