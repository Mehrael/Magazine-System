using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Feedback
    {
        public Decimal id { get; set; }
        public Decimal sourceId { get; set; }
        public Decimal destinationId { get; set; }
        public Decimal MagazineId { get; set; }
        public String content { get; set; }
    }
}