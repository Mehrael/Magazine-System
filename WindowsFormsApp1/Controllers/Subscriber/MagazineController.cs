using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Collections;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers.Subscriber
{
    class MagazineController : DisconnectedController
    {
        public MagazineController()
        {
            table = "MAGAZINE";
        }

        public List<Magazine> Get()
        {
            string sql = $"SELECT ID, TITLE, DESCRIPTION, MAGAZINECOVER FROM {table} WHERE PUBLISHED = 1";

            var data = FillData(sql).Tables[0].Rows;

            var magazines = new List<Magazine>();
            for (int i = 0; i < data.Count; i++)
            {
                magazines.Add(new Magazine
                {
                    id = (Decimal)data[i]["ID"],
                    Title = (String)data[i]["TITLE"],
                    Description = (String)data[i]["DESCRIPTION"],
                    MagazineCover = (String)data[i]["MAGAZINECOVER"],
                });
            }

            return magazines;
        }

        public Magazine Show(int id)
        {
            try
            {
                string sql = $"SELECT ID, TITLE, DESCRIPTION, MAGAZINECOVER, CONTENT, AUTHORID " +
                $"FROM {table} WHERE {table}.ID = {id} AND PUBLISHED = 1";

                var data = FillData(sql).Tables[0].Rows;
                var magazineId = (Decimal)data[0]["ID"];

                string authorSql = $"SELECT ID, NAME FROM USERS WHERE ID = {data[0]["AUTHORID"]}";

                var author = FillData(authorSql).Tables[0].Rows[0];

                var likesCount = (new LikeController()).GetLikes(id);

                return new Magazine
                {
                    id = magazineId,
                    Title = (String)data[0]["TITLE"],
                    Content = (String)data[0]["CONTENT"],
                    Description = (String)data[0]["DESCRIPTION"],
                    MagazineCover = (String)data[0]["MAGAZINECOVER"],
                    likesCount = likesCount,
                    Author = new User
                    {
                        Id = (Decimal)author["ID"],
                        Name = (String)author["NAME"],
                    }
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}