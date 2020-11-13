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
    public partial class fm_Title : Form
    {
        private string connectionString { get; set; }
        private int titleID { get; set; } = 0;
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
        public fm_Title()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AttendanceSysContext"].ConnectionString.ToString();

        }

        private void fm_Title_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titleDS.Title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.FillBy(this.titleDS.Title);

            btn_Edit.Enabled = false;

            // 選取一整行
            dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 取消一次選取多行
            dgView.MultiSelect = false;

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
            if (string.IsNullOrEmpty(tbx_Title.Text))
            {
                MessageBox.Show("請輸入職位名稱!!");
                return;
            }

            sql = @"INSERT INTO [dbo].[Title]
                                       ([DepartmentID]
                                       ,[TitleName]
                                       ,[Description])
                                 VALUES
                                       (@DepartmentID
                                       ,@TitleName
                                       ,@Description)";

            cmd.CommandText = sql;
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Department.SelectedItem).Key;
            cmd.Parameters.Add("@TitleName", SqlDbType.NVarChar).Value = tbx_Title.Text;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = rtbx_Description.Text;

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
            if (string.IsNullOrEmpty(tbx_Title.Text))
            {
                MessageBox.Show("請輸入職位名稱!!");
                return;
            }

            sql = "UPDATE [dbo].[Title] SET [DepartmentID] = @DepartmentID ,[TitleName] = @TitleName ,[Description] = @Description WHERE [TitleID] = @TitleID ";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = ((ComboBoxItem)cbx_Department.SelectedItem).Key;
            cmd.Parameters.Add("@TitleName", SqlDbType.NVarChar).Value = tbx_Title.Text;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = rtbx_Description.Text;
            cmd.Parameters.Add("@TitleID", SqlDbType.Int).Value = titleID;

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
                titleID = ID;

                sql = "DELETE FROM [dbo].[Title] WHERE [TitleID] = @TitleID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@TitleID", SqlDbType.Int).Value = titleID;

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

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgView.CurrentCell.RowIndex;
            int ID = (int)dgView.Rows[row].Cells[0].Value;
            titleID = ID;

            sql = @"  SELECT TitleID,DepartmentName, TitleName, Description FROM dbo.Title AS T
                        INNER JOIN [SP_AttendanceSysDB].[dbo].[Department] AS D ON T.DepartmentID = D.DepartmentID WHERE [TitleID] = @TitleID";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@TitleID", SqlDbType.Int).Value = titleID;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    foreach (ComboBoxItem item in cbx_Department.Items)
                    {
                        if (item.Value == dr[1].ToString())
                        {
                            ComboBoxItem cb = new ComboBoxItem();
                            cb.Key = item.Key;
                            cb.Value = item.Value;


                            cbx_Department.SelectedIndex = cbx_Department.FindStringExact(dr[1].ToString());


                            break;
                        }
                    }

                    tbx_Title.Text = dr[2].ToString();
                    rtbx_Description.Text = dr[3].ToString();
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

        /// <summary>
        /// 復原為初始值
        /// </summary>
        private void ReturnInitial()
        {
            titleID = 0;
            btn_Insert.Enabled = true;
            btn_Edit.Enabled = false;
            tbx_Title.Text = string.Empty;
            cbx_Department.SelectedIndex = 0;
            rtbx_Description.Text = string.Empty;
        }

        /// <summary>
        /// 重新綁定
        /// </summary>
        private void ReBinding()
        {
            sql = @"SELECT TitleID,DepartmentName, TitleName, Description FROM dbo.Title AS T
                     INNER JOIN[SP_AttendanceSysDB].[dbo].[Department] AS D ON T.DepartmentID = D.DepartmentID";
            cmd.CommandText = sql;
            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ad.SelectCommand = cmd;
            ad.Fill(ds);

            dgView.DataSource = ds.Tables[0];
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

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取部門資料失敗...{ex.Message}");
            }
        }
    }

    public class ComboBoxItem
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
