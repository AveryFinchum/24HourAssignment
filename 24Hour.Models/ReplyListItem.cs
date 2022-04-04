using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class ReplyListItem
    {
        public int ReplyId { get; set; }
        public string RContent { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
