namespace AttendanceSysForCSharp
{
    partial class fm_PunchCardDay
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OffWork = new System.Windows.Forms.Button();
            this.btn_Work = new System.Windows.Forms.Button();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.nup_Hour = new System.Windows.Forms.NumericUpDown();
            this.nup_Minute = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Minute)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "打卡日期";
            // 
            // btn_OffWork
            // 
            this.btn_OffWork.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_OffWork.Location = new System.Drawing.Point(572, 23);
            this.btn_OffWork.Name = "btn_OffWork";
            this.btn_OffWork.Size = new System.Drawing.Size(67, 39);
            this.btn_OffWork.TabIndex = 7;
            this.btn_OffWork.Text = "下班";
            this.btn_OffWork.UseVisualStyleBackColor = true;
            // 
            // btn_Work
            // 
            this.btn_Work.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Work.Location = new System.Drawing.Point(497, 23);
            this.btn_Work.Name = "btn_Work";
            this.btn_Work.Size = new System.Drawing.Size(67, 39);
            this.btn_Work.TabIndex = 6;
            this.btn_Work.Text = "上班";
            this.btn_Work.UseVisualStyleBackColor = true;
            // 
            // dt_Date
            // 
            this.dt_Date.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dt_Date.Location = new System.Drawing.Point(122, 27);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(178, 27);
            this.dt_Date.TabIndex = 39;
            // 
            // nup_Hour
            // 
            this.nup_Hour.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.nup_Hour.Location = new System.Drawing.Point(306, 28);
            this.nup_Hour.Name = "nup_Hour";
            this.nup_Hour.Size = new System.Drawing.Size(46, 27);
            this.nup_Hour.TabIndex = 40;
            // 
            // nup_Minute
            // 
            this.nup_Minute.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.nup_Minute.Location = new System.Drawing.Point(358, 28);
            this.nup_Minute.Name = "nup_Minute";
            this.nup_Minute.Size = new System.Drawing.Size(46, 27);
            this.nup_Minute.TabIndex = 41;
            // 
            // fm_PunchCardDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.nup_Minute);
            this.Controls.Add(this.nup_Hour);
            this.Controls.Add(this.dt_Date);
            this.Controls.Add(this.btn_OffWork);
            this.Controls.Add(this.btn_Work);
            this.Controls.Add(this.label3);
            this.Name = "fm_PunchCardDay";
            this.Text = "打卡(日)";
            ((System.ComponentModel.ISupportInitialize)(this.nup_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OffWork;
        private System.Windows.Forms.Button btn_Work;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.NumericUpDown nup_Hour;
        private System.Windows.Forms.NumericUpDown nup_Minute;
    }
}