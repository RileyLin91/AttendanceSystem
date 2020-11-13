using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSysForCSharp
{
    public partial class fm_Employee : Form
    {
        private string connectionString { get; set; }
        private int employeeID { get; set; } = 0;
        private SqlConnection _conn;
        private SqlConnection conn
        {
            get
            {
                return _conn ?? (_conn = new SqlConnection(connectionString));
            }
            set
            {
                _conn = value;
            }
        }

        private SqlCommand _cmd;
        public SqlCommand cmd
        {
            get
            {
                _cmd = _cmd ?? (_cmd = new SqlCommand());
                _cmd.Connection = conn;
                return _cmd;
            }
        }

        private string sql;
        public fm_Employee()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AttendanceSysContext"].ConnectionString.ToString();
        }

        private void fm_Employee_Load(object sender, EventArgs e)
        {
            btn_Edit.Enabled = false;
            rb_Male.Checked = true;
            rb_StatusY.Checked = true;
            dt_ResignationDate.Enabled = false;
            cbx_Employee.DropDownStyle = ComboBoxStyle.DropDownList;

            // 為員工賦予項目
            AddEmployeeItem();
            cbx_Employee.DisplayMember = "Value";
            cbx_Employee.ValueMember = "Key";
            cbx_Employee.SelectedIndex = -1;

            // 為部門賦予項目
            AddDepartmentItem();
            cbx_Department.DisplayMember = "Value";
            cbx_Department.ValueMember = "Key";
            cbx_Department.SelectedIndex = 0;
        }

        /// <summary>
        /// 新增作業
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_ChineseName.Text))
            {
                MessageBox.Show("請輸入中文姓名!!");
                return;

            }

            if (string.IsNullOrEmpty(tbx_EnglishName.Text))
            {
                MessageBox.Show("請輸入英文姓名!!");
                return;
            }

            if (string.IsNullOrEmpty(tbx_IDNumber.Text))
            {
                MessageBox.Show("請輸入身分證字號!!");
                return;
            }


            sql = @"INSERT INTO [dbo].[Employee]
                                       ([EmployeeCode]
                                       ,[DepartmentID]
                                       ,[ChineseName]
                                       ,[EnglishName]
                                       ,[TitleID]
                                       ,[IDNumber]
                                       ,[Birthday]
                                       ,[Gender]
                                       ,[HomeAddress]
                                       ,[CurrentAddress]
                                       ,[Email]
                                       ,[HomeTel]
                                       ,[CurrentTel]
                                       ,[MobileTel]
                                       ,[HireDate]
                                    
                                       ,[JobStatus])
                                 VALUES
                                       (@EmployeeCode
                                       ,@DepartmentID
                                       ,@ChineseName
                                       ,@EnglishName
                                       ,@TitleID
                                       ,@IDNumber
                                       ,@Birthday
                                       ,@Gender
                                       ,@HomeAddress
                                       ,@CurrentAddress
                                       ,@Email
                                       ,@HomeTel
                                       ,@CurrentTel
                                       ,@MobileTel
                                       ,@HireDate
                                      
                                       ,@JobStatus)";

            cmd.CommandText = sql;
            cmd.Parameters.Add("@EmployeeCode", SqlDbType.Int).Value = tbx_EmployeeCode.Text;
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Department.SelectedItem).Key;
            cmd.Parameters.Add("@ChineseName", SqlDbType.Char).Value = tbx_ChineseName.Text;
            cmd.Parameters.Add("@EnglishName", SqlDbType.Char).Value = tbx_EnglishName.Text;
            cmd.Parameters.Add("@TitleID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Title.SelectedItem).Key;
            cmd.Parameters.Add("@IDNumber", SqlDbType.Char).Value = tbx_IDNumber.Text;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = dt_Birth.Value;
            cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = rb_Male.Checked == true ? 'M' : 'F';
            cmd.Parameters.Add("@HomeAddress", SqlDbType.Char).Value = tbx_HomeAddress.Text;
            cmd.Parameters.Add("@CurrentAddress", SqlDbType.Char).Value = tbx_CurrentAddress.Text;
            cmd.Parameters.Add("@Email", SqlDbType.Char).Value = tbx_EMail.Text;
            cmd.Parameters.Add("@HomeTel", SqlDbType.Char).Value = tbx_HomeTel.Text;
            cmd.Parameters.Add("@CurrentTel", SqlDbType.Char).Value = tbx_CurrentTel.Text;
            cmd.Parameters.Add("@MobileTel", SqlDbType.Char).Value = tbx_MobileTel.Text;
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).Value = dt_HireDate.Value;

            cmd.Parameters.Add("@JobStatus", SqlDbType.Bit).Value = rb_StatusY.Checked == true ? 1 : 0;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Parameters.Clear();

                MessageBox.Show("新增成功!!");
                ReturnInitial();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show($"Ooops! 新增失敗...{ex.Message}");
            }
        }

        /// <summary>
        /// 修改作業
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_ChineseName.Text))
            {
                MessageBox.Show("請輸入中文姓名!!");
                return;

            }

            if (string.IsNullOrEmpty(tbx_EnglishName.Text))
            {
                MessageBox.Show("請輸入英文姓名!!");
                return;
            }

            if (string.IsNullOrEmpty(tbx_IDNumber.Text))
            {
                MessageBox.Show("請輸入身分證字號!!");
                return;
            }


            sql = @"UPDATE [dbo].[Employee]
                               SET [EmployeeCode] = @EmployeeCode
                                  ,[DepartmentID] = @DepartmentID
                                  ,[ChineseName] = @ChineseName
                                  ,[EnglishName] = @EnglishName
                                  ,[TitleID] = @TitleID
                                  ,[IDNumber] = @IDNumber
                                  ,[Birthday] = @Birthday
                                  ,[Gender] = @Gender
                                  ,[HomeAddress] = @HomeAddress
                                  ,[CurrentAddress] = @CurrentAddress
                                  ,[Email] = @Email
                                  ,[HomeTel] = @HomeTel
                                  ,[CurrentTel] = @CurrentTel
                                  ,[MobileTel] = @MobileTel
                                  ,[HireDate] = @HireDate
                                  ,[ResignationDate] = @ResignationDate
                                  ,[JobStatus] = @JobStatus
                             WHERE [EmployeeID] = @EmployeeID ";

            cmd.CommandText = sql;

            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;
            cmd.Parameters.Add("@EmployeeCode", SqlDbType.Int).Value = tbx_EmployeeCode.Text;
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Department.SelectedItem).Key;
            cmd.Parameters.Add("@ChineseName", SqlDbType.Char).Value = tbx_ChineseName.Text;
            cmd.Parameters.Add("@EnglishName", SqlDbType.Char).Value = tbx_EnglishName.Text;
            cmd.Parameters.Add("@TitleID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Title.SelectedItem).Key;
            cmd.Parameters.Add("@IDNumber", SqlDbType.Char).Value = tbx_IDNumber.Text;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = dt_Birth.Value;
            cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = rb_Male.Checked == true ? 'M' : 'F';
            cmd.Parameters.Add("@HomeAddress", SqlDbType.Char).Value = tbx_HomeAddress.Text;
            cmd.Parameters.Add("@CurrentAddress", SqlDbType.Char).Value = tbx_CurrentAddress.Text;
            cmd.Parameters.Add("@Email", SqlDbType.Char).Value = tbx_EMail.Text;
            cmd.Parameters.Add("@HomeTel", SqlDbType.Char).Value = tbx_HomeTel.Text;
            cmd.Parameters.Add("@CurrentTel", SqlDbType.Char).Value = tbx_CurrentTel.Text;
            cmd.Parameters.Add("@MobileTel", SqlDbType.Char).Value = tbx_MobileTel.Text;
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).Value = dt_HireDate.Value;
            cmd.Parameters.Add("@ResignationDate", SqlDbType.Date).Value = DBNull.Value;
            cmd.Parameters.Add("@JobStatus", SqlDbType.Bit).Value = rb_StatusY.Checked == true ? 1 : 0;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

                MessageBox.Show("修改成功!!");
                ReturnInitial();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show($"Ooops! 修改失敗...{ex.Message}");
            }
        }

        /// <summary>
        /// 取消作業
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ReturnInitial();
        }

        /// <summary>
        /// 復原為初始值
        /// </summary>
        private void ReturnInitial()
        {
            employeeID = 0;
            btn_Insert.Enabled = true;
            btn_Edit.Enabled = false;
            rb_Male.Checked = true;
            rb_StatusY.Checked = true;
            cbx_Department.SelectedIndex = 0;
            cbx_Title.SelectedIndex = 0;
            cbx_Employee.SelectedIndex = -1;
            tbx_ChineseName.Text = string.Empty;
            tbx_EnglishName.Text = string.Empty;
            tbx_IDNumber.Text = string.Empty;
            tbx_CurrentTel.Text = string.Empty;
            tbx_HomeTel.Text = string.Empty;
            tbx_MobileTel.Text = string.Empty;
            tbx_CurrentAddress.Text = string.Empty;
            tbx_HomeAddress.Text = string.Empty;
            tbx_EMail.Text = string.Empty;
            tbx_EmployeeCode.Text = string.Empty;
            dt_Birth.Value = DateTime.Now;
            dt_HireDate.Value = DateTime.Now;
            dt_ResignationDate.Value = DateTime.Now;
        }

        /// <summary>
        /// 員工 ComboBox 賦項目
        /// </summary>
        private void AddEmployeeItem()
        {
            sql = "SELECT [EmployeeID] ,[EmployeeCode], [ChineseName], [EnglishName] FROM [SP_AttendanceSysDB].[dbo].[Employee]";
            cmd.CommandText = sql;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string str = $"{(int)dr[1]}-{dr[2].ToString().Trim()}({dr[3].ToString().Trim()})";

                    ComboBoxItem item = new ComboBoxItem();
                    item.Key = (int)dr[0];
                    item.Value = str;

                    cbx_Employee.Items.Add(item);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取員工資料失敗...{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 部門 ComboBox 賦項目
        /// </summary>
        private void AddDepartmentItem()
        {
            sql = "SELECT [DepartmentID], [DepartmentName] FROM [dbo].[Department] ORDER BY [DepartmentID]";
            cmd.CommandText = sql;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Key = (int)dr[0];
                    item.Value = (string)dr[1];

                    cbx_Department.Items.Add(item);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取部門資料失敗...{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 職位 ComboBox 賦項目
        /// </summary>
        private void AddTitleItem()
        {
            sql = "SELECT [TitleID] ,[TitleName] FROM [SP_AttendanceSysDB].[dbo].[Title] WHERE [DepartmentID] = @DepartmentID";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Department.SelectedItem).Key;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Key = (int)dr[0];
                    item.Value = (string)dr[1];

                    cbx_Title.Items.Add(item);
                }

                cmd.Parameters.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取職位資料失敗...{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbx_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_Title.Items.Clear();
            AddTitleItem();
            cbx_Title.DisplayMember = "Value";
            cbx_Title.ValueMember = "Key";
            cbx_Title.SelectedIndex = 0;
        }

        private void cbx_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Employee.SelectedIndex == -1)
                return;

            employeeID = ((ComboBoxItem)cbx_Employee.SelectedItem).Key;
            sql = @"SELECT [EmployeeID]
                          ,[EmployeeCode]
                          ,[DepartmentID]
                          ,[ChineseName]
                          ,[EnglishName]
                          ,[TitleID]
                          ,[IDNumber]
                          ,[Birthday]
                          ,[Gender]
                          ,[HomeAddress]
                          ,[CurrentAddress]
                          ,[Email]
                          ,[HomeTel]
                          ,[CurrentTel]
                          ,[MobileTel]
                          ,[HireDate]
                          ,[ResignationDate]
                          ,[JobStatus]
                      FROM [SP_AttendanceSysDB].[dbo].[Employee] WHERE [EmployeeID] = @EmployeeID";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;

            int D_key = 0;
            int T_key = 0;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tbx_EmployeeCode.Text = dr[1].ToString();
                    D_key = (int)dr[2];
                    tbx_ChineseName.Text = dr[3].ToString();
                    tbx_EnglishName.Text = dr[4].ToString();
                    T_key = (int)dr[5];
                    tbx_IDNumber.Text = dr[6].ToString();
                    dt_Birth.Value = (DateTime)dr[7];

                    if (dr[8].ToString() == "M")
                        rb_Male.Checked = true;
                    else
                        rb_Female.Checked = true;

                    tbx_HomeAddress.Text = dr[9].ToString();
                    tbx_CurrentAddress.Text = dr[10].ToString();
                    tbx_EMail.Text = dr[11].ToString();
                    tbx_HomeTel.Text = dr[12].ToString();
                    tbx_CurrentTel.Text = dr[13].ToString();
                    tbx_MobileTel.Text = dr[14].ToString();
                    dt_HireDate.Value = (DateTime)dr[15];
                    dt_ResignationDate.Value = string.IsNullOrEmpty(dr[16].ToString()) ? DateTime.Now : (DateTime)dr[16];

                    if ((bool)dr[17])
                    {
                        rb_StatusY.Checked = true;
                    }
                    else
                    {
                        rb_StatusN.Checked = true;
                        dt_ResignationDate.Enabled = true;
                    }
                }

                cmd.Parameters.Clear();

                btn_Insert.Enabled = false;
                btn_Edit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取資料失敗...{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            // DepartmenetID
            foreach (ComboBoxItem item in cbx_Department.Items)
            {
                if (item.Key == (int)D_key)
                {
                    cbx_Department.SelectedIndex = cbx_Department.FindStringExact(item.Value);

                    break;
                }
            }

            // TitleID
            foreach (ComboBoxItem item in cbx_Title.Items)
            {
                if (item.Key == (int)T_key)
                {
                    cbx_Title.SelectedIndex = cbx_Title.FindStringExact(item.Value);

                    break;
                }
            }
        }
    }

}
