namespace AttendanceSysForCSharp
{
    partial class fm_Holidays
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.rb_No = new System.Windows.Forms.RadioButton();
            this.rb_Yes = new System.Windows.Forms.RadioButton();
            this.rtbx_Description = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbx_Description);
            this.groupBox1.Controls.Add(this.rb_No);
            this.groupBox1.Controls.Add(this.rb_Yes);
            this.groupBox1.Controls.Add(this.dt_Date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "假日管理";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(160, 12);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 39);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Edit.Location = new System.Drawing.Point(87, 12);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(67, 39);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Insert.Location = new System.Drawing.Point(12, 12);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(67, 39);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "是否放假";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "描述";
            // 
            // dt_Date
            // 
            this.dt_Date.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dt_Date.Location = new System.Drawing.Point(133, 35);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(178, 27);
            this.dt_Date.TabIndex = 38;
            // 
            // rb_No
            // 
            this.rb_No.AutoSize = true;
            this.rb_No.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_No.Location = new System.Drawing.Point(193, 79);
            this.rb_No.Name = "rb_No";
            this.rb_No.Size = new System.Drawing.Size(42, 20);
            this.rb_No.TabIndex = 41;
            this.rb_No.TabStop = true;
            this.rb_No.Text = "否";
            this.rb_No.UseVisualStyleBackColor = true;
            // 
            // rb_Yes
            // 
            this.rb_Yes.AutoSize = true;
            this.rb_Yes.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_Yes.Location = new System.Drawing.Point(133, 79);
            this.rb_Yes.Name = "rb_Yes";
            this.rb_Yes.Size = new System.Drawing.Size(42, 20);
            this.rb_Yes.TabIndex = 40;
            this.rb_Yes.TabStop = true;
            this.rb_Yes.Text = "是";
            this.rb_Yes.UseVisualStyleBackColor = true;
            // 
            // rtbx_Description
            // 
            this.rtbx_Description.Location = new System.Drawing.Point(133, 120);
            this.rtbx_Description.Name = "rtbx_Description";
            this.rtbx_Description.Size = new System.Drawing.Size(624, 65);
            this.rtbx_Description.TabIndex = 42;
            this.rtbx_Description.Text = "";
            // 
            // fm_Holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Insert);
            this.Name = "fm_Holidays";
            this.Text = "國定假日管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.RichTextBox rtbx_Description;
        private System.Windows.Forms.RadioButton rb_No;
        private System.Windows.Forms.RadioButton rb_Yes;
    }
}