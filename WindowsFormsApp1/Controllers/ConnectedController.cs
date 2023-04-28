﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using WindowsFormsApp1.Models;
namespace WindowsFormsApp1.Controllers
{
   public class ConnectedController
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public int updateState(int id,int state)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand updateCommand = new OracleCommand();
            updateCommand.Connection = conn;
            updateCommand.CommandText = "update Magazine set Approved=:state where ID=:id";
            updateCommand.Parameters.Add("state", state);
            updateCommand.Parameters.Add("ID", id);
            return updateCommand.ExecuteNonQuery();
        }
        public int sendFeedbackToAuthor(Feedback feedback)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand insertCommand = new OracleCommand();
            insertCommand.Connection = conn;
            insertCommand.CommandText = "insert into Feedbacks values (:id,:feedback,:sourceId,:destId,:magazineId)";
            insertCommand.Parameters.Add("id", feedback.id);
            insertCommand.Parameters.Add("feedback",feedback.content);
            insertCommand.Parameters.Add("sourceId", feedback.sourceId);
            insertCommand.Parameters.Add("destId", feedback.destinationId);
            insertCommand.Parameters.Add("magazineId", feedback.MagazineId);
            return insertCommand.ExecuteNonQuery();
        }

        public List<Magazine> GetMagazines()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
             List<Magazine> magazines=new List<Magazine>();
            OracleCommand procedure = new OracleCommand();
            procedure.Connection = conn;
            procedure.CommandText = "GetUnapprovedMagazines";
            procedure.CommandType = System.Data.CommandType.StoredProcedure;
            procedure.Parameters.Add("p_magazines", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
            OracleDataReader dataReader = procedure.ExecuteReader();
            while (dataReader.Read())
            {
                Magazine magazine = new Magazine();
                magazine.id = dataReader.GetDecimal(0);
                magazine.Title = dataReader.GetString(1);
                magazine.authorId = dataReader.GetDecimal(2);
                magazine.Description = dataReader.GetString(3);
                magazine.Content = dataReader.GetString(4);
                magazine.Approved = dataReader.GetDecimal(5);
                magazine.Published = dataReader.GetDecimal(6);
                magazine.MagazineCover = dataReader.GetString(7);
                magazines.Add(magazine);
            }
            return magazines;
            }
        public List<Feedback> GetFeedbacks() {
            conn = new OracleConnection(ordb);
            conn.Open();
            List<Feedback> feedbacks = new List<Feedback>();
            OracleCommand procedure = new OracleCommand();
            procedure.Connection = conn;
            procedure.CommandText = "get_feeds";
            procedure.CommandType = System.Data.CommandType.StoredProcedure;
            procedure.Parameters.Add("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
            OracleDataReader dataReader = procedure.ExecuteReader();
            while (dataReader.Read())
            {
                Feedback feedback = new Feedback();
                feedback.id = dataReader.GetDecimal(0);
                feedback.content = dataReader.GetString(1);
                feedback.sourceId = dataReader.GetDecimal(2);
                feedback.destinationId = dataReader.GetDecimal(3);
                feedback.MagazineId = dataReader.GetDecimal(4);
                feedbacks.Add(feedback);
            }
            return feedbacks;

        }
        public List<User> GetAuthors()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            List<User> authors = new List<User>();
            OracleCommand procedure = new OracleCommand();
            procedure.Connection = conn;
            procedure.CommandText = "get_authors";
            procedure.CommandType = System.Data.CommandType.StoredProcedure;
            procedure.Parameters.Add("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
            OracleDataReader dataReader = procedure.ExecuteReader();
            while (dataReader.Read())
            {
                User author = new User();
                author.Id = dataReader.GetDecimal(0);
              // var x = dataReader.GetDecimal(5);

                author.Name = dataReader.GetString(1);
               author.Email = dataReader.GetString(2);
               author.Password = dataReader.GetString(3);
                author.RoleId = dataReader.GetDecimal(4);
                try
                {
                    author.SubscriptionId = dataReader.GetDecimal(5);
                }
                catch
                {
                    author.SubscriptionId = -1;
                }
                authors.Add(author);
                Console.WriteLine(author.Name);
            }
            return authors;

        }

    }
}
