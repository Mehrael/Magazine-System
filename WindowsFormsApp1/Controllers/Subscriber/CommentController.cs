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
    class CommentController: DisconnectedController
    {
        private int MagazineId;

        public CommentController(int magazineId)
        {
            table = "Comments";
            MagazineId = magazineId;
        }

        public bool Create(string comment)
        {
            string id = GetLastRecord(table);

            string sql = $"INSERT INTO {table} (ID, COMMENT, SUBSCRIBERID, MAGAZINEID) " +
                $"VALUES ({id}, {comment}, 0, {MagazineId})";

            return AffectData(sql) > 0;
        }

        public bool Update(int id, string comment)
        {
            string sql = $"UPDATE {table} SET COMMENT = {comment} WHERE ID = {id}";
            
            return AffectData(sql) > 0;
        }

        public bool Delete(int id)
        {
            string sql = $"DELETE FROM {table} WHERE ID = {id}";

            return AffectData(sql) > 0;
        }
    }
}
