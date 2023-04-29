using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        UsersReport usersReport;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usersReport = new UsersReport();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            usersReport.SetParameterValue(0,Convert.ToDateTime(startdate_txt.Text));
            usersReport.SetParameterValue(1, Convert.ToDateTime(enddate_txt.Text));

            crystalReportViewer1.ReportSource = usersReport;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
