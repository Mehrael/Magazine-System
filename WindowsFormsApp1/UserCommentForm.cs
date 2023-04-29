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
using WindowsFormsApp1.Controllers.Subscriber;

namespace WindowsFormsApp1
{
    public partial class UserCommentForm : Form
    {

        DisconnectedController disconnected = new DisconnectedController();
        static MagazineController magazine = new MagazineController();
        List<Magazine> PublishedMagazine = magazine.Get();

        public UserCommentForm()
        {
            InitializeComponent();
        }

        private void UserCommentForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < PublishedMagazine.Count; i++)
                magazine_list.Items.Add(PublishedMagazine[i].Title);

        }

        private void magazine_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int  index = magazine_list.FocusedItem.Index;

            Magazine m = magazine.Show(Convert.ToInt32(PublishedMagazine[index].id));

            LikesCount_lbl.Text = m.likesCount.ToString() + " Likes";
            Author_txt.Text = m.Author.Name.ToString();
            magazine_description_txt.Text = PublishedMagazine[index].Description;
            Title_txt.Text = PublishedMagazine[index].Title;
            
        }
    }
}
