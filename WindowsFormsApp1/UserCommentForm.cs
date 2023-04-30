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
        Magazine m;
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

           m = magazine.Show(Convert.ToInt32(PublishedMagazine[index].id));

            LikesCount_lbl.Text = m.likesCount.ToString() + " Likes";

            Author_txt.Text = m.Author.Name.ToString();
            magazine_description_txt.Text = PublishedMagazine[index].Description;
            Title_txt.Text = PublishedMagazine[index].Title;
            Content_txt.Text = m.Content;
            
        }

        private void Like_btn_Click(object sender, EventArgs e)
        {
            if (magazine_list.SelectedItems.Count > 0)
            {
                LikeController likeController = new LikeController();
            Like like = new Like();
            like.LIKE_DISLIKE = 1;
            like.SUBSCRIBERID = 2; //*************** get it from login form
            like.MAGAZINEID = PublishedMagazine[magazine_list.FocusedItem.Index].id;

            like = likeController.Create(like);
                if (like != null)
                {
                    MessageBox.Show("Liked");
                    m.likesCount++;
                    LikesCount_lbl.Text = m.likesCount.ToString() + " Likes";
                }

        }
            else
                MessageBox.Show("Select a magazine first");

            this.Refresh();
        }

        private void Dislike_btn_Click(object sender, EventArgs e)
        {
            if (magazine_list.SelectedItems.Count > 0)
            {
                LikeController likeController = new LikeController();
            Like like = new Like();
            like.LIKE_DISLIKE = 0;
            like.SUBSCRIBERID = 2; //*******************
            like.MAGAZINEID = PublishedMagazine[magazine_list.FocusedItem.Index].id;

            like = likeController.Create(like);
                if (like != null)
                {
                    MessageBox.Show("DisLiked");
                    m.likesCount--;
                    LikesCount_lbl.Text = m.likesCount.ToString() + " Likes";
                }
            }
            else
                MessageBox.Show("Select a magazine first");
        }

        private void Submit_btn_Click_1(object sender, EventArgs e)
        {
            if (magazine_list.SelectedItems.Count > 0)
            {
                Comment comment = new Comment();
                comment.USERCOMMENT = Comment_txt.Text;
                comment.SUBSCRIBERID = 1;
                comment.MAGAZINEID = PublishedMagazine[magazine_list.FocusedItem.Index].id;

                CommentController commentController = new CommentController();
                comment = commentController.Create(comment, Convert.ToInt32(comment.MAGAZINEID));

                if (comment != null)
                    MessageBox.Show("commented");
            }
            else
                MessageBox.Show("Select a magazine first");
        }

        private void LikesCount_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
