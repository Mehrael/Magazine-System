using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controllers;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Collections;

namespace WindowsFormsApp1.Controllers.Subscriber
{
    class LikeController: DisconnectedController
    {
        private int MagazineId;

        public LikeController(int magazineId)
        {
            table = "Likes";
            MagazineId = magazineId;
        }

        public bool Create(int value)
        {
            string id = GetLastRecord(table);

            string sql = $"INSERT INTO {table} (ID, LIKE_DISLIKE, SUBSCRIBERID, MAGAZINEID) " +
                $"VALUES ({id}, {value}, 0, {MagazineId})";

            return AffectData(sql) > 0;
        }

        public bool Update(int id, int value)
        {
            string sql = $"UPDATE {table} SET LIKE_DISLIKE = {value} WHERE ID = {id}";

            return AffectData(sql) > 0;
        }
    }
}
