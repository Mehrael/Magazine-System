namespace WindowsFormsApp1
{
    partial class GenerateReports
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
            this.generate_usrs_rep = new System.Windows.Forms.Button();
            this.generate_mags_rep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate_usrs_rep
            // 
            this.generate_usrs_rep.Location = new System.Drawing.Point(15, 78);
            this.generate_usrs_rep.Name = "generate_usrs_rep";
            this.generate_usrs_rep.Size = new System.Drawing.Size(186, 35);
            this.generate_usrs_rep.TabIndex = 0;
            this.generate_usrs_rep.Text = "Generate user\'s data report";
            this.generate_usrs_rep.UseVisualStyleBackColor = true;
            this.generate_usrs_rep.Click += new System.EventHandler(this.generate_usrs_rep_Click);
            // 
            // generate_mags_rep
            // 
            this.generate_mags_rep.Location = new System.Drawing.Point(245, 78);
            this.generate_mags_rep.Name = "generate_mags_rep";
            this.generate_mags_rep.Size = new System.Drawing.Size(186, 35);
            this.generate_mags_rep.TabIndex = 1;
            this.generate_mags_rep.Text = "Generate magaziens report";
            this.generate_mags_rep.UseVisualStyleBackColor = true;
            this.generate_mags_rep.Click += new System.EventHandler(this.generate_mags_rep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generate_usrs_rep);
            this.groupBox1.Controls.Add(this.generate_mags_rep);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports generation";
            // 
            // GenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 215);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerateReports";
            this.Text = "GenerateReports";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate_usrs_rep;
        private System.Windows.Forms.Button generate_mags_rep;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}