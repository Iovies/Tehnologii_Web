using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMCS.Models.Models
{
    public class ImageDbModel
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Article")]
        public Guid ArticleId { get; set; }

        public virtual ArticleDbModel Article { get; set; }
    }
}