using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
   public class Magazine
    {
        public Decimal id { get; set; }
        public String Title { get; set; }
        public Decimal authorId { get; set; }
        public String Description { get; set; }
        public String Content { get; set; }
        public Decimal Approved { get; set; }
        public Decimal Published { get; set; }
        public String MagazineCover { get; set; }
        public Decimal likesCount { get; set; }
        public User Author;
    }
}
