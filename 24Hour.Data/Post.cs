using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(3400, ErrorMessage ="Too many characters in this field")]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        public virtual List<Comments> Comments { get; set; }
    }
}
