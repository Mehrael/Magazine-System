namespace WindowsFormsApp1
{
    partial class Form1
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
            this.generate_report = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.startdate_txt = new System.Windows.Forms.TextBox();
            this.enddate_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generate_report
            // 
            this.generate_report.Location = new System.Drawing.Point(536, 54);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(75, 23);
            this.generate_report.TabIndex = 0;
            this.generate_report.Text = "Generate";
            this.generate_report.UseVisualStyleBackColor = true;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 118);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(776, 421);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // startdate_txt
            // 
            this.startdate_txt.Location = new System.Drawing.Point(79, 29);
            this.startdate_txt.Name = "startdate_txt";
            this.startdate_txt.Size = new System.Drawing.Size(243, 20);
            this.startdate_txt.TabIndex = 2;
            // 
            // enddate_txt
            // 
            this.enddate_txt.Location = new System.Drawing.Point(79, 74);
            this.enddate_txt.Name = "enddate_txt";
            this.enddate_txt.Size = new System.Drawing.Size(243, 20);
            this.enddate_txt.TabIndex = 3;
            this.enddate_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enddate_txt);
            this.Controls.Add(this.startdate_txt);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.generate_report);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox startdate_txt;
        private System.Windows.Forms.TextBox enddate_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}