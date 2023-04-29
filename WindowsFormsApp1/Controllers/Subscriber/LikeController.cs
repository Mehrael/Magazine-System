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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers.Subscriber
{
    class LikeController: DisconnectedController
    {
        public LikeController()
        {
            table = "LIKES";
        }
        public Decimal GetLikes(int magazineId) {
            try
            {
                string sql = $"SELECT COUNT(ID) FROM {table} WHERE MAGAZINEID = {magazineId} AND LIKE_DESLIKE = 1";

                var data = FillData(sql).Tables[0].Rows[0][0];

                return (Decimal)data;
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public bool Create(Like like)
        {
            try
            {
                var id = GetLastRecord(table);

                string sql = $"INSERT INTO {table} (ID, LIKE_DISLIKE, SUBSCRIBERID, MAGAZINEID) " +
                    $"VALUES ({id}, {like.LIKE_DISLIKE}, {like.SUBSCRIBERID}, {like.MAGAZINEID})";

                return AffectData(sql) > 0;
            }
            catch(Exception e)
            {
                return false;
            }
}

        public bool Update(Like like)
        {
            try
            {
                string sql = $"UPDATE {table} SET LIKE_DISLIKE = {like.LIKE_DISLIKE} WHERE MAGAZINEID = {like.MAGAZINEID}";

                return AffectData(sql) > 0;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
