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
            this.reviewTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.authors_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.Location = new System.Drawing.Point(6, 61);
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(875, 201);
            this.reviewTextBox.TabIndex = 0;
            this.reviewTextBox.Text = "";
            this.reviewTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.send_btn);
            this.groupBox1.Controls.Add(this.authors_comboBox);
            this.groupBox1.Controls.Add(this.reviewTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write a review";
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
            // authors_comboBox
            // 
            this.authors_comboBox.FormattingEnabled = true;
            this.authors_comboBox.Location = new System.Drawing.Point(776, 19);
            this.authors_comboBox.Name = "authors_comboBox";
            this.authors_comboBox.Size = new System.Drawing.Size(121, 21);
            this.authors_comboBox.TabIndex = 1;
            this.authors_comboBox.SelectedIndexChanged += new System.EventHandler(this.authorsIds_comboBox_SelectedIndexChanged);
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 682);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReviewerForm";
            this.Text = "Reviewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox reviewTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox authors_comboBox;
        private System.Windows.Forms.Button send_btn;
    }
}

