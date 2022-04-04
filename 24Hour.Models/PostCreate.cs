using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(1, ErrorMessage ="Please enter at least 1 character.")]
        [MaxLength(100, ErrorMessage = "Too many characters in the title.")]
        public string Title { get; set; }
        [MaxLength(3000)]
        public string Text { get; set; }
    }
}
