﻿using System;
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
    class LikeController : DisconnectedController
    {
        public LikeController()
        {
            table = "LIKES";
        }
        public Decimal GetLikes(int magazineId)
        {
            try
            {
                string sql = $"SELECT COUNT(ID) FROM {table} WHERE MAGAZINEID = {magazineId} AND LIKE_DISLIKE = 1";

                var data = FillData(sql).Tables[0].Rows[0][0];

                return (Decimal)data;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public Like Create(Like like)
        {
            try
            {
                var id = GetLastRecord(table);

                string sql = $"INSERT INTO {table} (ID, LIKE_DISLIKE, SUBSCRIBERID, MAGAZINEID) " +
                    $"VALUES ({id}, {like.LIKE_DISLIKE}, {like.SUBSCRIBERID}, {like.MAGAZINEID})";

                UpdateTable($"SELECT * FROM Likes", new object[] { id, like.LIKE_DISLIKE, like.SUBSCRIBERID, like.MAGAZINEID });

                like.ID = id;

                return like;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Like Update(Like like)
        {
            try
            {
                string sql = $"UPDATE {table} SET LIKE_DISLIKE = {like.LIKE_DISLIKE} WHERE MAGAZINEID = {like.MAGAZINEID}";

                UpdateTable($"SELECT * FROM COMMENTS", new object[] { like.ID, like.LIKE_DISLIKE, like.SUBSCRIBERID, like.MAGAZINEID });

                return like;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}