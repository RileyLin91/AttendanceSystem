namespace AttendanceSysForCSharp
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Basic_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Department_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Holidays_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonWork_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PunchCardDay_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PunchCardMonth_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportWork_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Basic_ToolStripMenuItem,
            this.PersonWork_ToolStripMenuItem,
            this.ReportWork_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Basic_ToolStripMenuItem
            // 
            this.Basic_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Employee_ToolStripMenuItem,
            this.Department_ToolStripMenuItem,
            this.Title_ToolStripMenuItem,
            this.Holidays_ToolStripMenuItem1});
            this.Basic_ToolStripMenuItem.Name = "Basic_ToolStripMenuItem";
            this.Basic_ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.Basic_ToolStripMenuItem.Text = "基本資料維護";
            // 
            // Employee_ToolStripMenuItem
            // 
            this.Employee_ToolStripMenuItem.Name = "Employee_ToolStripMenuItem";
            this.Employee_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.Employee_ToolStripMenuItem.Text = "員工管理";
            this.Employee_ToolStripMenuItem.Click += new System.EventHandler(this.Employee_ToolStripMenuItem_Click);
            // 
            // Department_ToolStripMenuItem
            // 
            this.Department_ToolStripMenuItem.Name = "Department_ToolStripMenuItem";
            this.Department_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.Department_ToolStripMenuItem.Text = "部門管理";
            this.Department_ToolStripMenuItem.Click += new System.EventHandler(this.Department_ToolStripMenuItem_Click);
            // 
            // Title_ToolStripMenuItem
            // 
            this.Title_ToolStripMenuItem.Name = "Title_ToolStripMenuItem";
            this.Title_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.Title_ToolStripMenuItem.Text = "職位管理";
            this.Title_ToolStripMenuItem.Click += new System.EventHandler(this.Title_ToolStripMenuItem_Click);
            // 
            // Holidays_ToolStripMenuItem1
            // 
            this.Holidays_ToolStripMenuItem1.Name = "Holidays_ToolStripMenuItem1";
            this.Holidays_ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.Holidays_ToolStripMenuItem1.Text = "國定假日管理";
            this.Holidays_ToolStripMenuItem1.Click += new System.EventHandler(this.Holidays_ToolStripMenuItem1_Click);
            // 
            // PersonWork_ToolStripMenuItem
            // 
            this.PersonWork_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PunchCardDay_ToolStripMenuItem,
            this.PunchCardMonth_ToolStripMenuItem});
            this.PersonWork_ToolStripMenuItem.Name = "PersonWork_ToolStripMenuItem";
            this.PersonWork_ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.PersonWork_ToolStripMenuItem.Text = "個人工作";
            // 
            // PunchCardDay_ToolStripMenuItem
            // 
            this.PunchCardDay_ToolStripMenuItem.Name = "PunchCardDay_ToolStripMenuItem";
            this.PunchCardDay_ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.PunchCardDay_ToolStripMenuItem.Text = "打卡(日)";
            this.PunchCardDay_ToolStripMenuItem.Click += new System.EventHandler(this.PunchCardDay_ToolStripMenuItem_Click);
            // 
            // PunchCardMonth_ToolStripMenuItem
            // 
            this.PunchCardMonth_ToolStripMenuItem.Name = "PunchCardMonth_ToolStripMenuItem";
            this.PunchCardMonth_ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.PunchCardMonth_ToolStripMenuItem.Text = "打卡(月)";
            this.PunchCardMonth_ToolStripMenuItem.Click += new System.EventHandler(this.PunchCardMonth_ToolStripMenuItem_Click);
            // 
            // ReportWork_ToolStripMenuItem
            // 
            this.ReportWork_ToolStripMenuItem.Name = "ReportWork_ToolStripMenuItem";
            this.ReportWork_ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ReportWork_ToolStripMenuItem.Text = "報表作業";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 672);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Basic_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Employee_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Department_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Title_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Holidays_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PersonWork_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PunchCardDay_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PunchCardMonth_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportWork_ToolStripMenuItem;
    }
}