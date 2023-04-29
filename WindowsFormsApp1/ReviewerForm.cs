using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1
{ 
    public partial class ReviewerForm : Form
    {

        ConnectedController connected;
        public ReviewerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectedController connected = new ConnectedController();

            List<User> authors = connected.GetAuthors();
            authors_comboBox.DataSource = authors;
            authors_comboBox.DisplayMember = "Name";
            authors_comboBox.ValueMember = "Id";

            List<Magazine> notApprovedMagazine = connected.GetUnapporvedMagazines();
            magazines_list.DataSource = notApprovedMagazine;
            magazines_list.DisplayMember = "Title";
            magazines_list.ValueMember = "Id";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void authorsIds_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var review=reviewTextBox.Text;
            Feedback feedback = new Feedback();
          //  feedback.sourceId=
            //connected.sendFeedbackToAuthor();
        }

        private void magazines_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mag = (Magazine)magazines_list.SelectedItem;
            magazine_description_txt.Text = mag.Description;
        }

        private void magazines_list_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void magazines_list_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }
    }
}
