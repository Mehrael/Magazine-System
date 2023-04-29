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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enddate_txt = new System.Windows.Forms.TextBox();
            this.startdate_txt = new System.Windows.Forms.TextBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.generate_report = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 423);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comments report";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.enddate_txt);
            this.tabPage2.Controls.Add(this.startdate_txt);
            this.tabPage2.Controls.Add(this.crystalReportViewer2);
            this.tabPage2.Controls.Add(this.generate_report);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subsrciption report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(836, 391);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "End date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start date";
            // 
            // enddate_txt
            // 
            this.enddate_txt.Location = new System.Drawing.Point(93, 57);
            this.enddate_txt.Name = "enddate_txt";
            this.enddate_txt.Size = new System.Drawing.Size(243, 20);
            this.enddate_txt.TabIndex = 9;
            this.enddate_txt.Text = "01-JUN-25";
            // 
            // startdate_txt
            // 
            this.startdate_txt.Location = new System.Drawing.Point(93, 20);
            this.startdate_txt.Name = "startdate_txt";
            this.startdate_txt.Size = new System.Drawing.Size(243, 20);
            this.startdate_txt.TabIndex = 8;
            this.startdate_txt.Text = "01-JUN-20";
            this.startdate_txt.TextChanged += new System.EventHandler(this.startdate_txt_TextChanged);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(6, 83);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(833, 314);
            this.crystalReportViewer2.TabIndex = 7;
            // 
            // generate_report
            // 
            this.generate_report.Location = new System.Drawing.Point(454, 32);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(75, 23);
            this.generate_report.TabIndex = 6;
            this.generate_report.Text = "Generate";
            this.generate_report.UseVisualStyleBackColor = true;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // GenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 447);
            this.Controls.Add(this.tabControl1);
            this.Name = "GenerateReports";
            this.Text = "GenerateReports";
            this.Load += new System.EventHandler(this.GenerateReports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enddate_txt;
        private System.Windows.Forms.TextBox startdate_txt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Button generate_report;
    }
}