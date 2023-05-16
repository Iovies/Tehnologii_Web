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
    public class ArticleDbModel
    {
        [Key]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Article title")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Article description")]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Article content")]
        public string Content { get; set; }

        [DisplayName("Article publish date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [DisplayName("Article likes")]
        [DefaultValue(0)]
        public int Likes { get; set; }

        [DisplayName("Article last update date")]
        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("AuthorID")]
        public UserDbModel Author { get; set; }

        [DefaultValue(false)]
        public bool HasCover { get; set; }

        [DefaultValue(null)]
        public Guid CoverID { get; set; }

        [DefaultValue(false)]
        public bool HasGallery { get; set; }

        [DefaultValue(null)]
        public virtual ICollection<ImageDbModel> GalleryImages { get; set; }
    }
}
