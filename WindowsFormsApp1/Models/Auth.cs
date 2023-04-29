using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    static class Auth
    {
        public static Decimal? ID { get; set; }
        public static String Name { get; set; }
        public static String Email { get; set; }
        public static Decimal? RoleId { get; set; }
        public static Decimal? SubscriptionId { get; set; }

        public static void FillAuth(DataRow data)
        {
            Auth.ID = (Decimal)data["ID"];
            Auth.Name = (String)data["NAME"];
            Auth.Email = (String)data["EMAIL"];
            Auth.RoleId = (Decimal)data["ROLEID"];
            Console.WriteLine("SUBSCRIPTIONID => " + data["SUBSCRIPTIONID"]);
            try { 
                Auth.SubscriptionId = (Decimal)data["SUBSCRIPTIONID"];
            }
            catch
            {

            }
        }
    }
}
