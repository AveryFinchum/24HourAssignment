using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class ReplyCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Not enough characters for a reply!")]
        [MaxLength(5000, ErrorMessage = "You used up all your characters for your reply!")]
        public string RContent { get; set; }

    }
}
