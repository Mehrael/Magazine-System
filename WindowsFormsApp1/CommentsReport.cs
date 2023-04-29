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
    public partial class CommentsReport : Form
    {
        public CommentsReport()
        {
            InitializeComponent();
        }

        private void CommentsReport_Load(object sender, EventArgs e)
        {
            MagazineReport magazineReport = new MagazineReport();
            crystalReportViewer1.ReportSource = magazineReport;
        }
    }
}
