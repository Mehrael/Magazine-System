using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class User
    {
        public Decimal Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Decimal RoleId { get; set; }
        public Decimal? SubscriptionId { get; set; }
    }
}
