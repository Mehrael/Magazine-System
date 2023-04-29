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
    class CommentController : DisconnectedController
    {
        public CommentController()
        {
            table = "Comments";
        }

        public bool Create(Comment comment, int magazineId)
        {
            try
            {
                var id = GetLastRecord(table);

                string sql = $"INSERT INTO {table} (ID, USERCOMMENT, SUBSCRIBERID, MAGAZINEID) " +
                    $"VALUES ({id}, {comment.USERCOMMENT}, {comment.SUBSCRIBERID}, {comment.MAGAZINEID})";

                return AffectData(sql) > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(Comment comment)
        {
            try
            {
                string sql = $"UPDATE {table} SET USERCOMMENT = {comment.USERCOMMENT} WHERE ID = {comment.ID}";

                return AffectData(sql) > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                string sql = $"DELETE FROM {table} WHERE ID = {id}";

                return AffectData(sql) > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}