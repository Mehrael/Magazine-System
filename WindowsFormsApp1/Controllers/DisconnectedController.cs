using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class DisconnectedController
    {
        protected string conn { get; set; }
        protected string table { get; set; }

        protected OracleDataAdapter adapter { get; set; }
        protected OracleConnection orclConn { get; set; }
        protected OracleCommand command { get; set; }
        protected DataSet ds { get; set; }

        public DisconnectedController()
        {
            conn = "Data Source=orcl; User Id=scott; Password=tiger;";
        }

        public string GetLastRecord(string table)
        {
            string getLastCommentSql = $"SELECT ID FROM {table} ORDER BY ID DESC LIMIT 1";

            ds = FillData(getLastCommentSql);

            int id = (int)(ds.Tables[0].Rows[0]["ID"]) + 1;

            return id.ToString();
        }

        public DataSet FillData(string sql)
        {
            adapter = new OracleDataAdapter(sql, conn);

            ds = new DataSet();

            adapter.Fill(ds);

            return ds;
        }

        public int AffectData(string sql)
        {
            orclConn = new OracleConnection(conn);
            command = new OracleCommand(sql, orclConn);

            int numRowsAffected = command.ExecuteNonQuery();

            return numRowsAffected;
        }

        public DataSet Get()
        {
            table = "likes";
            string sql = $"select * from {table}";
            orclConn = new OracleConnection(conn);
            adapter = new OracleDataAdapter(sql, orclConn);
            ds = new DataSet();

            adapter.Fill(ds);

            return ds;
        }

        public void Update(int magazineId)
        {
            // Create a new dataset
            DataSet like = new DataSet();

            // Fill the dataset with data from the server
            using (orclConn = new OracleConnection(conn))
            {
                OracleDataAdapter da = new OracleDataAdapter($"SELECT * FROM {table} where magazineId={magazineId}", orclConn);
                da.Fill(like);
            }
            /*
             GetType().GetProperties()
             [
              {
                id: 1
              },
              {
                name: "ahmed"
              }
             ]
             */
            // Modify the data in the dataset
            /*foreach (var m in like.GetType().GetProperties()){
                ds.Tables[0].Rows[0][m.Name] = m.GetValue(this, null);
            }*/

            ds.Tables[0].Rows[0]["isLike"] = 0;

            // Update the changes back to the server
            using (OracleConnection orclConn = new OracleConnection(conn))
            {
                OracleDataAdapter da = new OracleDataAdapter($"SELECT * FROM {table}", conn);

                OracleCommandBuilder cb = new OracleCommandBuilder(da);
                da.Update(ds, table);
            }
        }
    }
}
