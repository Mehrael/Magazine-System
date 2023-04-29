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

        ConnectedController connected=new ConnectedController();
    
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
            Feedback feedback = new Feedback();
            Magazine mag = (Magazine)magazines_list.SelectedItem;
            feedback.content = reviewTextBox.Text;
            feedback.destinationId = mag.authorId;
            feedback.id = connected.GenerateId("feedbacks");
            feedback.MagazineId = mag.id;
            feedback.sourceId = 12;
           int r= connected.sendFeedbackToAuthor(feedback);
            if (r != -1)
                MessageBox.Show("Feedback sent!");
            else
                MessageBox.Show("Error, feedback not sent");

        }

        private void magazines_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectedController connected = new ConnectedController();
            var mag = (Magazine)magazines_list.SelectedItem;
           if(mag!=null)
            magazine_description_txt.Text = mag.Description;
        }

        private void magazines_list_SelectedValueChanged(object sender, EventArgs e)
        {
           
                ConnectedController connected = new ConnectedController();
                for (int i = 0; i <= (magazines_list.Items.Count - 1); i++)
                {
                    Magazine mag = (Magazine)magazines_list.Items[i];
                    int r;
                    if (magazines_list.GetItemChecked(i))
                    {
                        if (mag.Approved == 0)
                        {
                            r = connected.updateState(mag.id, 1);
                            if (r == 1)
                            {
                                MessageBox.Show("Magazine approved");
                                mag.Approved = 1;
                            }
                            else
                            {
                                MessageBox.Show("Error happend, magazien not approved");
                            }
                        }
                    }
                    else
                    {
                        if (mag.Approved == 1)
                        {
                            r = connected.updateState(mag.id, 0);
                            if (r == 1)
                            {
                                MessageBox.Show("Magazine approval removed");
                                mag.Approved = 0;
                            }
                            else
                            {
                                MessageBox.Show("Error happend, magazien approval not removed");
                            }
                        }
                    }
                }
            

        }

        private void magazines_list_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ConnectedController connected = new ConnectedController();
            for (int i = 0; i <= (magazines_list.Items.Count - 1); i++)
            {
                Magazine mag = (Magazine)magazines_list.Items[i];
                int r;
                if (magazines_list.GetItemChecked(i))
                {
                    if (mag.Approved == 0)
                    {
                        r = connected.updateState(mag.id, 1);
                        if (r == 1)
                        {
                            MessageBox.Show("Magazine approved");
                            mag.Approved = 1;
                        }
                        else
                        {
                            MessageBox.Show("Error happend, magazien not approved");
                        }
                    }
                }
                else
                {
                    if (mag.Approved == 1)
                    {
                        r = connected.updateState(mag.id, 0);
                        if (r == 1)
                        {
                            MessageBox.Show("Magazine approval removed");
                            mag.Approved = 0;
                        }
                        else
                        {
                            MessageBox.Show("Error happend, magazien approval not removed");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            magazines_list.DataSource = null;
            magazines_list.Items.Clear();
            List<Magazine> notApprovedMagazine = connected.GetUnapporvedMagazines();
            magazines_list.DataSource = notApprovedMagazine;
            magazines_list.DisplayMember = "Title";
            magazines_list.ValueMember = "Id";
           
            //for (int i = 0; i <= (magazines_list.Items.Count - 1); i++)
            //{
            //    Magazine mag = (Magazine)magazines_list.Items[i];
            //    if (mag.Approved==0)
            //    magazines_list.SetItemCheckState(i, CheckState.Unchecked);
            //}
        }
    }
}
