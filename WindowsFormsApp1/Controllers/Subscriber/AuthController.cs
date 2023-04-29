using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers.Subscriber
{
    class AuthController: DisconnectedController
    {
        public AuthController()
        {
            table = "USERS";
        }

        public User Login(User user)
        {
            try
            {
                string sql = $"SELECT * FROM {table} WHERE EMAIL = '{user.Email}'";

                var data = FillData(sql).Tables[0].Rows[0];

                if(user.Password != (String)(data["PASSWORD"]))
                {
                    MessageBox.Show("Incorrect Password");
                    return null;
                }

                Auth.FillAuth(data);

                if(user.RoleId==2 || user.RoleId == 3)
                {

                }

                return new User {
                    Id = (Decimal)data["ID"],
                    Name = (String)data["NAME"],
                    Email = (String)data["EMAIL"],
                    RoleId = (Decimal)data["ROLEID"],
                };
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public User Register(User user)
        {
            try
            {
                string sql = $"SELECT * FROM {table} WHERE EMAIL = '{user.Email}'";

                var data = FillData(sql).Tables[0].Rows;

                if(data.Count > 0)
                {
                    MessageBox.Show("Email already used");
                    return null;
                }

                var id = GetLastRecord(table);

                var insertSql = $"INSERT INTO {table} (ID, NAME, EMAIL, PASSWORD, ROLEID, SUBSCRIPTIONID) " +
                    $"VALUES ({id}, {user.Name}, {user.Email}, {user.Password}, {user.RoleId}, {user.SubscriptionId})";

                UpdateTable($"SELECT * FROM USERS", new object[] {id, user.Name, user.Email, user.Password, user.RoleId, user.SubscriptionId});

                /*if(AffectData(insertSql) <= 0)
                {
                    throw new Exception();
                }*/

                Auth.ID = id;
                Auth.Name = user.Name;
                Auth.Email = user.Email;
                Auth.RoleId = user.RoleId;

                user.Id = id;

                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
