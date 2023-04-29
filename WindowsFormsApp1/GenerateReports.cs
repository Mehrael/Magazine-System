using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp1
{
    public partial class GenerateReports : Form
    {
        public GenerateReports()
        {
            InitializeComponent();
        }

        private void generate_usrs_rep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 users = new Form1();
            users.Closed+=(s, args) => this.Close();
            users.Show();
        }

        private void generate_mags_rep_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommentsReport comments = new CommentsReport();
            comments.Closed += (s, args) => this.Close();
            comments.Show();
        }

    }
}
