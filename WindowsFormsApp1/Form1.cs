using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Controllers.Subscriber;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private AuthController _controller;

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Login_Panel.Visible = false;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Login_Panel.Visible = true;
        }

        private void guna2GradientTileButton2_Click_1(object sender, EventArgs e)
        {
            _controller = new AuthController();

            User user = _controller.Login(new User
            {
                Email = email_box.Text,
                Password = password_box.Text
            });

            if (user == null)
            {
                return;
            }

            /*
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close(); 
                form2.Show();
             */

            if (user.RoleId == 2 || user.RoleId == 3)
            {
                this.Hide();
                var form2 = new ReviewerForm(user);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (user.RoleId == 1)
            {
                this.Hide();
                var form2 = new UserCommentForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("You are not a manager or reviewer");
            }
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            _controller = new AuthController();

            User user = _controller.Register(new User
            {
                Name = name_box.Text,
                Email = email_box2.Text,
                Password = password_box2.Text,
                confirmPassword = confirm_password_box.Text,
                RoleId = 1,
                SubscriptionId = null
            });

            if (user == null)
            {
                return;
            }

            /*
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close(); 
                form2.Show();
             */

            if (user.RoleId == 2 || user.RoleId == 3)
            {
                this.Hide();
                var form2 = new ReviewerForm(user);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (user.RoleId == 1)
            {
                this.Hide();
                var form2 = new UserCommentForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("You are not a manager or reviewer");
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
