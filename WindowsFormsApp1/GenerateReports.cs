using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GenerateReports : Form
    {
        UsersReport usersReport=new UsersReport();

        MagazineReport magazineReport = new MagazineReport();
    
        public GenerateReports()
        {
            InitializeComponent();
        }

        private void generate_usrs_rep_Click(object sender, EventArgs e)
        {
        
        }

        private void generate_mags_rep_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            usersReport.SetParameterValue(0, Convert.ToDateTime(startdate_txt.Text));
            usersReport.SetParameterValue(1, Convert.ToDateTime(enddate_txt.Text));
            crystalReportViewer2.ReportSource = usersReport;
        }

        private void GenerateReports_Load(object sender, EventArgs e)
        {
         
            crystalReportViewer1.ReportSource = magazineReport;

        }

        private void startdate_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
