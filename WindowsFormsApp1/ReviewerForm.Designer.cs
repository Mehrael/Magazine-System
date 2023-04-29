namespace WindowsFormsApp1
{
    partial class ReviewerForm
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
            this.magazine_description_txt = new System.Windows.Forms.RichTextBox();
            this.magazines_list = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.magazines_list_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reviewTextBox = new System.Windows.Forms.RichTextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // magazine_description_txt
            // 
            this.magazine_description_txt.Location = new System.Drawing.Point(311, 43);
            this.magazine_description_txt.Name = "magazine_description_txt";
            this.magazine_description_txt.ReadOnly = true;
            this.magazine_description_txt.Size = new System.Drawing.Size(582, 292);
            this.magazine_description_txt.TabIndex = 3;
            this.magazine_description_txt.Text = "";
            // 
            // magazines_list
            // 
            this.magazines_list.FormattingEnabled = true;
            this.magazines_list.Location = new System.Drawing.Point(18, 27);
            this.magazines_list.Name = "magazines_list";
            this.magazines_list.Size = new System.Drawing.Size(254, 304);
            this.magazines_list.TabIndex = 4;
            this.magazines_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.magazines_list_ItemCheck);
            this.magazines_list.SelectedIndexChanged += new System.EventHandler(this.magazines_list_SelectedIndexChanged);
            this.magazines_list.SelectedValueChanged += new System.EventHandler(this.magazines_list_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // magazines_list_label
            // 
            this.magazines_list_label.AutoSize = true;
            this.magazines_list_label.Location = new System.Drawing.Point(15, 9);
            this.magazines_list_label.Name = "magazines_list_label";
            this.magazines_list_label.Size = new System.Drawing.Size(122, 13);
            this.magazines_list_label.TabIndex = 6;
            this.magazines_list_label.Text = "Unapproved magazines ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected magazine description";
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.Location = new System.Drawing.Point(6, 19);
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(875, 243);
            this.reviewTextBox.TabIndex = 0;
            this.reviewTextBox.Text = "";
            this.reviewTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(806, 268);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.send_btn);
            this.groupBox1.Controls.Add(this.reviewTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write a review";
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magazines_list_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.magazines_list);
            this.Controls.Add(this.magazine_description_txt);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReviewerForm";
            this.Text = "Reviewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox magazine_description_txt;
        private System.Windows.Forms.CheckedListBox magazines_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label magazines_list_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox reviewTextBox;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

