namespace AttendanceSysForCSharp
{
    partial class fm_Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.publicHolidaysTableAdapter = new AttendanceSysForCSharp.PublicHolidaysDSTableAdapters.PublicHolidaysTableAdapter();
            this.publicHolidaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicHolidaysDS = new AttendanceSysForCSharp.PublicHolidaysDS();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDS = new AttendanceSysForCSharp.DepartmentDS();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_DepartmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new AttendanceSysForCSharp.DepartmentDSTableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.publicHolidaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicHolidaysDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // publicHolidaysTableAdapter
            // 
            this.publicHolidaysTableAdapter.ClearBeforeFill = true;
            // 
            // publicHolidaysBindingSource
            // 
            this.publicHolidaysBindingSource.DataMember = "PublicHolidays";
            this.publicHolidaysBindingSource.DataSource = this.publicHolidaysDS;
            // 
            // publicHolidaysDS
            // 
            this.publicHolidaysDS.DataSetName = "PublicHolidaysDS";
            this.publicHolidaysDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.Delete});
            this.dgView.DataSource = this.departmentBindingSource;
            this.dgView.Location = new System.Drawing.Point(12, 164);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(570, 321);
            this.dgView.TabIndex = 12;
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            this.dgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "部門代號";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "部門名稱";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "刪除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "刪除";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "刪除";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.departmentDS;
            // 
            // departmentDS
            // 
            this.departmentDS.DataSetName = "DepartmentDS";
            this.departmentDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(515, 24);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 39);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_DepartmentName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部門管理";
            // 
            // tbx_DepartmentName
            // 
            this.tbx_DepartmentName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_DepartmentName.Location = new System.Drawing.Point(111, 41);
            this.tbx_DepartmentName.Name = "tbx_DepartmentName";
            this.tbx_DepartmentName.Size = new System.Drawing.Size(438, 27);
            this.tbx_DepartmentName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "部門名稱";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Edit.Location = new System.Drawing.Point(442, 24);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(67, 39);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_Insert.Location = new System.Drawing.Point(367, 24);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(67, 39);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // fm_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 497);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Insert);
            this.Name = "fm_Department";
            this.Text = "部門管理";
            this.Load += new System.EventHandler(this.fm_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicHolidaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicHolidaysDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PublicHolidaysDSTableAdapters.PublicHolidaysTableAdapter publicHolidaysTableAdapter;
        private System.Windows.Forms.BindingSource publicHolidaysBindingSource;
        private PublicHolidaysDS publicHolidaysDS;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox tbx_DepartmentName;
        private DepartmentDS departmentDS;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DepartmentDSTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}