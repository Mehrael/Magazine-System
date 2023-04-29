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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // magazine_description_txt
            // 
            this.magazine_description_txt.Location = new System.Drawing.Point(415, 53);
            this.magazine_description_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.magazine_description_txt.Name = "magazine_description_txt";
            this.magazine_description_txt.ReadOnly = true;
            this.magazine_description_txt.Size = new System.Drawing.Size(775, 358);
            this.magazine_description_txt.TabIndex = 3;
            this.magazine_description_txt.Text = "";
            // 
            // magazines_list
            // 
            this.magazines_list.FormattingEnabled = true;
            this.magazines_list.Location = new System.Drawing.Point(24, 33);
            this.magazines_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.magazines_list.Name = "magazines_list";
            this.magazines_list.Size = new System.Drawing.Size(337, 361);
            this.magazines_list.TabIndex = 4;
            this.magazines_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.magazines_list_ItemCheck);
            this.magazines_list.SelectedIndexChanged += new System.EventHandler(this.magazines_list_SelectedIndexChanged);
            this.magazines_list.SelectedValueChanged += new System.EventHandler(this.magazines_list_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // magazines_list_label
            // 
            this.magazines_list_label.AutoSize = true;
            this.magazines_list_label.Location = new System.Drawing.Point(20, 11);
            this.magazines_list_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.magazines_list_label.Name = "magazines_list_label";
            this.magazines_list_label.Size = new System.Drawing.Size(162, 17);
            this.magazines_list_label.TabIndex = 6;
            this.magazines_list_label.Text = "Unapproved magazines ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected magazine description";
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.Location = new System.Drawing.Point(8, 23);
            this.reviewTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(1165, 298);
            this.reviewTextBox.TabIndex = 0;
            this.reviewTextBox.Text = "";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(1075, 330);
            this.send_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(100, 28);
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.send_btn);
            this.groupBox1.Controls.Add(this.reviewTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 446);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1196, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write a review";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 852);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(588, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Test Reports";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 895);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magazines_list_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.magazines_list);
            this.Controls.Add(this.magazine_description_txt);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReviewerForm";
            this.Text = "Reviewer";
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
        private System.Windows.Forms.Button button2;
    }
}

