using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AttendanceSysForCSharp
{
    public partial class fm_Department : Form
    {
        private string connectionString { get; set; }
        private int departmentID { get; set; } = 0;
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

        public fm_Department()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AttendanceSysContext"].ConnectionString.ToString();
        }

        private void fm_Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentDS.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.departmentDS.Department);

            btn_Edit.Enabled = false;

            // 選取一整行
            dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 取消一次選取多行
            dgView.MultiSelect = false;
        }

        /// <summary>
        /// 新增作業
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_DepartmentName.Text))
            {
                MessageBox.Show("請輸入部門名稱!!");
                return;
            }

            sql = "INSERT INTO [dbo].[Department] ([DepartmentName]) VALUES (@DepartmentName)";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@DepartmentName", SqlDbType.NVarChar).Value = tbx_DepartmentName.Text;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Parameters.Clear();

                MessageBox.Show("新增成功!!");
                ReturnInitial();
                ReBinding();
            }
            catch (Exception ex)
            {
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
            if (string.IsNullOrEmpty(tbx_DepartmentName.Text))
            {
                MessageBox.Show("請輸入部門名稱!!");
                return;
            }

            sql = "UPDATE [dbo].[Department] SET [DepartmentName] = @DepartmentName WHERE [DepartmentID] = @ID ";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@DepartmentName", SqlDbType.NVarChar).Value = tbx_DepartmentName.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = departmentID;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Parameters.Clear();

                MessageBox.Show("修改資料成功!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 修改資料失敗...{ex.Message}");
            }

            ReturnInitial();
            ReBinding();

            btn_Insert.Enabled = true;
            btn_Edit.Enabled = false;
        }

        /// <summary>
        /// 取消作業
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ReturnInitial();

            // DataGridView 失去焦點
            dgView.ClearSelection();
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 執行刪除行
            if (dgView.Columns[e.ColumnIndex].Name == "Delete")
            {
                int row = dgView.CurrentCell.RowIndex;
                int ID = (int)dgView.Rows[row].Cells[0].Value;
                departmentID = ID;

                sql = "DELETE FROM [dbo].[Department] WHERE [DepartmentID] = @ID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = departmentID;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cmd.Parameters.Clear();

                    MessageBox.Show("刪除成功!!");

                    ReBinding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ooops! 刪除失敗...{ex.Message}");
                }
            }
        }

        /// <summary>
        /// 復原為初始值
        /// </summary>
        private void ReturnInitial()
        {
            departmentID = 0;
            btn_Insert.Enabled = true;
            btn_Edit.Enabled = false;
            tbx_DepartmentName.Text = string.Empty;
        }

        /// <summary>
        /// 重新綁定
        /// </summary>
        private void ReBinding()
        {
            sql = "SELECT [DepartmentID], [DepartmentName] FROM[dbo].[Department] ORDER BY [DepartmentID]";
            cmd.CommandText = sql;
            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ad.SelectCommand = cmd;
            ad.Fill(ds);

            dgView.DataSource = ds.Tables[0];
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgView.CurrentCell.RowIndex;
            int ID = (int)dgView.Rows[row].Cells[0].Value;
            departmentID = ID;

            sql = "SELECT [DepartmentID] ,[DepartmentName] FROM [dbo].[Department] WHERE [DepartmentID] = @ID";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = departmentID;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tbx_DepartmentName.Text = dr[1].ToString();
                }

                conn.Close();
                cmd.Parameters.Clear();

                btn_Insert.Enabled = false;
                btn_Edit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取資料失敗...{ex.Message}");
            }
        }
    }
}
