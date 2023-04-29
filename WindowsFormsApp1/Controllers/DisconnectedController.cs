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

        protected DataSet FillData(string sql)
        {
            adapter = new OracleDataAdapter(sql, conn);

            ds = new DataSet();

            adapter.Fill(ds);

            return ds;
        }

        protected void UpdateTable(string sql, object[] obj)
        {
            adapter = new OracleDataAdapter(sql, conn);

            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

            ds = new DataSet();

            adapter.Fill(ds);
            ds.Tables[0].Rows.Add(obj);

            adapter.Update(ds);
        }

        protected int AffectData(string sql)
        {
            orclConn = new OracleConnection(conn);
            command = new OracleCommand(sql, orclConn);

            int numRowsAffected = command.ExecuteNonQuery();

            return numRowsAffected;
        }

        protected Decimal GetLastRecord(string table)
        {
            string getLastCommentSql = $"SELECT MAX (ID) FROM {table}";

            ds = FillData(getLastCommentSql);

            var id = (ds.Tables[0].Rows[0]);

            return (Decimal)id[0] + 1;
        }
    }
}
