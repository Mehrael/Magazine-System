using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Collections;

namespace WindowsFormsApp1.Controllers.Subscriber
{
    class MagazineController: DisconnectedController
    {
        public MagazineController()
        {
            table = "Magazines";
        }

        public DataSet Get()
        {
            string sql = $"SELECT ID, TITLE, DESCRIPTION, MAGAZINECOVER, " +
                $"COUNT(Comments.ID) AS COMMENTS, COUNT(Likes.ID) AS LIKES" +
                $"FROM {table} WHERE PUBLISHED = 1" +
                $"LEFT JOIN Comments ON {table}.ID = Comments.MagazineID " +
                $"LEFT JOIN Likes ON {table}.ID = Likes.MagazineID WHERE Likes.Like_Dislike = 1" +
                $"GROUP BY {table}.ID;";

            return FillData(sql);
        }

        public DataRow Show(int id)
        {
            string sql = $"SELECT ID, TITLE, DESCRIPTION, MAGAZINECOVER, CONTENT" +
                $"Comments.* AS COMMENTS, COUNT(Likes.ID) AS LIKES" +
                $"FROM {table} WHERE {table}.ID = {id} AND WHERE PUBLISHED = 1" +
                $"LEFT JOIN Comments ON {table}.ID = Comments.MagazineID " +
                $"LEFT JOIN Likes ON {table}.ID = Likes.MagazineID WHERE Likes.Like_Dislike = 1" +
                $"GROUP BY {table}.ID;";

            return FillData(sql).Tables[0].Rows[0];
        }
    }
}
