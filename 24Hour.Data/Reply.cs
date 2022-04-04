using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public  class Reply
    {
        [Key]
        public int ReplyId { get; set; }

        [Required]
        public string RContent { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
