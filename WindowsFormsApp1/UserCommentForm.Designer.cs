namespace WindowsFormsApp1
{
    partial class UserCommentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.magazines_list_label = new System.Windows.Forms.Label();
            this.magazine_description_txt = new System.Windows.Forms.RichTextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Comment_txt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Title_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.magazine_list = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.Author_txt = new System.Windows.Forms.RichTextBox();
            this.Like_btn = new System.Windows.Forms.Button();
            this.Dislike_btn = new System.Windows.Forms.Button();
            this.LikesCount_lbl = new System.Windows.Forms.Label();
            this.Content_txt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selected magazine description";
            // 
            // magazines_list_label
            // 
            this.magazines_list_label.AutoSize = true;
            this.magazines_list_label.Location = new System.Drawing.Point(28, 24);
            this.magazines_list_label.Name = "magazines_list_label";
            this.magazines_list_label.Size = new System.Drawing.Size(109, 13);
            this.magazines_list_label.TabIndex = 13;
            this.magazines_list_label.Text = "Published magazines ";
            // 
            // magazine_description_txt
            // 
            this.magazine_description_txt.Location = new System.Drawing.Point(324, 145);
            this.magazine_description_txt.Name = "magazine_description_txt";
            this.magazine_description_txt.ReadOnly = true;
            this.magazine_description_txt.Size = new System.Drawing.Size(582, 92);
            this.magazine_description_txt.TabIndex = 10;
            this.magazine_description_txt.Text = "";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(806, 135);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click_1);
            // 
            // Comment_txt
            // 
            this.Comment_txt.Location = new System.Drawing.Point(6, 19);
            this.Comment_txt.Name = "Comment_txt";
            this.Comment_txt.Size = new System.Drawing.Size(875, 110);
            this.Comment_txt.TabIndex = 0;
            this.Comment_txt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Submit_btn);
            this.groupBox1.Controls.Add(this.Comment_txt);
            this.groupBox1.Location = new System.Drawing.Point(25, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write a comment";
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(324, 275);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.ReadOnly = true;
            this.Title_txt.Size = new System.Drawing.Size(582, 92);
            this.Title_txt.TabIndex = 10;
            this.Title_txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selected magazine title";
            // 
            // magazine_list
            // 
            this.magazine_list.HideSelection = false;
            this.magazine_list.Location = new System.Drawing.Point(26, 46);
            this.magazine_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.magazine_list.Name = "magazine_list";
            this.magazine_list.Size = new System.Drawing.Size(261, 288);
            this.magazine_list.TabIndex = 16;
            this.magazine_list.UseCompatibleStateImageBehavior = false;
            this.magazine_list.View = System.Windows.Forms.View.List;
            this.magazine_list.SelectedIndexChanged += new System.EventHandler(this.magazine_list_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Selected magazine Author:";
            // 
            // Author_txt
            // 
            this.Author_txt.Location = new System.Drawing.Point(323, 63);
            this.Author_txt.Name = "Author_txt";
            this.Author_txt.ReadOnly = true;
            this.Author_txt.Size = new System.Drawing.Size(582, 37);
            this.Author_txt.TabIndex = 10;
            this.Author_txt.Text = "";
            // 
            // Like_btn
            // 
            this.Like_btn.Location = new System.Drawing.Point(57, 382);
            this.Like_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Like_btn.Name = "Like_btn";
            this.Like_btn.Size = new System.Drawing.Size(46, 26);
            this.Like_btn.TabIndex = 17;
            this.Like_btn.Text = "Like";
            this.Like_btn.UseVisualStyleBackColor = true;
            this.Like_btn.Click += new System.EventHandler(this.Like_btn_Click);
            // 
            // Dislike_btn
            // 
            this.Dislike_btn.Location = new System.Drawing.Point(201, 382);
            this.Dislike_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dislike_btn.Name = "Dislike_btn";
            this.Dislike_btn.Size = new System.Drawing.Size(50, 26);
            this.Dislike_btn.TabIndex = 17;
            this.Dislike_btn.Text = "DisLike";
            this.Dislike_btn.UseVisualStyleBackColor = true;
            this.Dislike_btn.Click += new System.EventHandler(this.Dislike_btn_Click);
            // 
            // LikesCount_lbl
            // 
            this.LikesCount_lbl.AutoSize = true;
            this.LikesCount_lbl.Location = new System.Drawing.Point(36, 353);
            this.LikesCount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LikesCount_lbl.Name = "LikesCount_lbl";
            this.LikesCount_lbl.Size = new System.Drawing.Size(41, 13);
            this.LikesCount_lbl.TabIndex = 18;
            this.LikesCount_lbl.Text = "0 Likes";
            this.LikesCount_lbl.Click += new System.EventHandler(this.LikesCount_lbl_Click);
            // 
            // Content_txt
            // 
            this.Content_txt.Location = new System.Drawing.Point(323, 405);
            this.Content_txt.Name = "Content_txt";
            this.Content_txt.ReadOnly = true;
            this.Content_txt.Size = new System.Drawing.Size(582, 92);
            this.Content_txt.TabIndex = 10;
            this.Content_txt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selected magazine content";
            // 
            // UserCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 716);
            this.Controls.Add(this.LikesCount_lbl);
            this.Controls.Add(this.Dislike_btn);
            this.Controls.Add(this.Like_btn);
            this.Controls.Add(this.magazine_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magazines_list_label);
            this.Controls.Add(this.Content_txt);
            this.Controls.Add(this.Title_txt);
            this.Controls.Add(this.Author_txt);
            this.Controls.Add(this.magazine_description_txt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UserCommentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Magazines";
            this.Load += new System.EventHandler(this.UserCommentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label magazines_list_label;
        private System.Windows.Forms.RichTextBox magazine_description_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.RichTextBox Comment_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox Title_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView magazine_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Author_txt;
        private System.Windows.Forms.Button Like_btn;
        private System.Windows.Forms.Button Dislike_btn;
        private System.Windows.Forms.Label LikesCount_lbl;
        private System.Windows.Forms.RichTextBox Content_txt;
        private System.Windows.Forms.Label label3;
    }
}