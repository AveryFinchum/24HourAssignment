using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
        public string RContent { get; set; }
        public DateTimeOffset dateTimeOffset { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
