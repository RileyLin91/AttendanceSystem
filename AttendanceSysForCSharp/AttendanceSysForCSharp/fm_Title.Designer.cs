namespace AttendanceSysForCSharp
{
    partial class fm_Title
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Department = new System.Windows.Forms.ComboBox();
            this.tbx_Title = new System.Windows.Forms.TextBox();
            this.rtbx_Description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDS = new AttendanceSysForCSharp.DepartmentDS();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDS = new AttendanceSysForCSharp.TitleDS();
            this.titleTableAdapter = new AttendanceSysForCSharp.TitleDSTableAdapters.TitleTableAdapter();
            this.titleDepartmentDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleDepartmentDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Department);
            this.groupBox1.Controls.Add(this.tbx_Title);
            this.groupBox1.Controls.Add(this.rtbx_Description);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "職位管理";
            // 
            // cbx_Department
            // 
            this.cbx_Department.FormattingEnabled = true;
            this.cbx_Department.Location = new System.Drawing.Point(166, 78);
            this.cbx_Department.Name = "cbx_Department";
            this.cbx_Department.Size = new System.Drawing.Size(271, 24);
            this.cbx_Department.TabIndex = 45;
            // 
            // tbx_Title
            // 
            this.tbx_Title.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Title.Location = new System.Drawing.Point(166, 39);
            this.tbx_Title.Name = "tbx_Title";
            this.tbx_Title.Size = new System.Drawing.Size(271, 27);
            this.tbx_Title.TabIndex = 44;
            // 
            // rtbx_Description
            // 
            this.rtbx_Description.Location = new System.Drawing.Point(166, 120);
            this.rtbx_Description.Name = "rtbx_Description";
            this.rtbx_Description.Size = new System.Drawing.Size(591, 65);
            this.rtbx_Description.TabIndex = 42;
            this.rtbx_Description.Text = "";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "部門";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "職位名稱";
            // 
            // departmentDSBindingSource
            // 
            this.departmentDSBindingSource.DataSource = this.departmentDS;
            this.departmentDSBindingSource.Position = 0;
            // 
            // departmentDS
            // 
            this.departmentDS.DataSetName = "DepartmentDS";
            this.departmentDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(722, 21);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 39);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Edit.Location = new System.Drawing.Point(649, 21);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(67, 39);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Insert.Location = new System.Drawing.Point(574, 21);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(67, 39);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.titleNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Delete});
            this.dgView.DataSource = this.titleBindingSource;
            this.dgView.Location = new System.Drawing.Point(13, 273);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(776, 332);
            this.dgView.TabIndex = 13;
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            this.dgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataMember = "Title";
            this.titleBindingSource.DataSource = this.titleDS;
            // 
            // titleDS
            // 
            this.titleDS.DataSetName = "TitleDS";
            this.titleDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleTableAdapter
            // 
            this.titleTableAdapter.ClearBeforeFill = true;
            // 
            // titleDSBindingSource
            // 
            this.titleDSBindingSource.DataSource = this.titleDS;
            this.titleDSBindingSource.Position = 0;
            // 
            // titleIDDataGridViewTextBoxColumn
            // 
            this.titleIDDataGridViewTextBoxColumn.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.HeaderText = "職位代碼";
            this.titleIDDataGridViewTextBoxColumn.Name = "titleIDDataGridViewTextBoxColumn";
            this.titleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "部門名稱";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleNameDataGridViewTextBoxColumn
            // 
            this.titleNameDataGridViewTextBoxColumn.DataPropertyName = "TitleName";
            this.titleNameDataGridViewTextBoxColumn.HeaderText = "職位名稱";
            this.titleNameDataGridViewTextBoxColumn.Name = "titleNameDataGridViewTextBoxColumn";
            this.titleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "描述";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "刪除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "刪除";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "刪除";
            // 
            // fm_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 625);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_Title";
            this.Text = "職位管理";
            this.Load += new System.EventHandler(this.fm_Title_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleDepartmentDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbx_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cbx_Department;
        private System.Windows.Forms.TextBox tbx_Title;
        private System.Windows.Forms.DataGridView dgView;
        private TitleDS titleDS;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private TitleDSTableAdapters.TitleTableAdapter titleTableAdapter;
        private System.Windows.Forms.BindingSource departmentDSBindingSource;
        private DepartmentDS departmentDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;

        private System.Windows.Forms.BindingSource titleDepartmentDSBindingSource;
        private System.Windows.Forms.BindingSource titleDSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}