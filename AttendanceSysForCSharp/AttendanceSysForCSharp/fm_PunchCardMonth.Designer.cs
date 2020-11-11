namespace AttendanceSysForCSharp
{
    partial class fm_PunchCardMonth
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
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Store = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dt_StartDate.Location = new System.Drawing.Point(108, 19);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(143, 27);
            this.dt_StartDate.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "開始日期";
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Export.Location = new System.Drawing.Point(677, 15);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(101, 39);
            this.btn_Export.TabIndex = 44;
            this.btn_Export.Text = "匯出Excel";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // btn_Store
            // 
            this.btn_Store.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Store.Location = new System.Drawing.Point(604, 15);
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(67, 39);
            this.btn_Store.TabIndex = 43;
            this.btn_Store.Text = "儲存";
            this.btn_Store.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Search.Location = new System.Drawing.Point(529, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(67, 39);
            this.btn_Search.TabIndex = 42;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(257, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "至";
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dt_EndDate.Location = new System.Drawing.Point(287, 19);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(143, 27);
            this.dt_EndDate.TabIndex = 46;
            // 
            // fm_PunchCardMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Store);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.label3);
            this.Name = "fm_PunchCardMonth";
            this.Text = "打卡(月)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Store;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
    }
}