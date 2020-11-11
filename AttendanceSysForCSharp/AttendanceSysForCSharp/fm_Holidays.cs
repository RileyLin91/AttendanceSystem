using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class fm_Holidays : Form
    {
        private string connectionString { get; set; }
        private int PublicHolidaysID { get; set; } = 0;
        public fm_Holidays()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AttendanceSysContext"].ConnectionString.ToString();
        }

        private void fm_Holidays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'publicHolidaysDS.PublicHolidays' table. You can move, or remove it, as needed.
            this.publicHolidaysTableAdapter.Fill(this.publicHolidaysDS.PublicHolidays);
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
            SqlConnection cn = new SqlConnection(connectionString);

            string sql = @"INSERT INTO [dbo].[PublicHolidays]
                                               ([Date]
                                               ,[IsHoliday]
                                               ,[Description])
                                         VALUES
                                               (@Date
                                               ,@IsHoliday
                                               ,@Description)";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dt_Date.Value;
            cmd.Parameters.Add("@IsHoliday", SqlDbType.Bit).Value = rb_Yes.Checked == true ? 1 : rb_No.Checked == true ? 0 : 1;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = rtbx_Description.Text;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("新增成功!!");
                ReturnInitial();
                ReBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 新增失敗...{ex.Message}");
            }
            finally
            {
                cn.Dispose();
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
            PublicHolidaysID = 0;
            btn_Insert.Enabled = true;
            btn_Edit.Enabled = false;
            dt_Date.Value = DateTime.Now;
            rb_Yes.Checked = true;
            rtbx_Description.Text = string.Empty;
        }

        /// <summary>
        /// 重新綁定
        /// </summary>
        private void ReBinding()
        {
            string sql = "SELECT PublicHolidaysID, Date, IsHoliday, Description FROM dbo.PublicHolidays ORDER BY PublicHolidaysID DESC";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            ad.SelectCommand = cmd;
            ad.Fill(ds);

            dgView.DataSource = ds.Tables[0];
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 執行刪除行
            if (dgView.Columns[e.ColumnIndex].Name == "Delete")
            {
                int row = dgView.CurrentCell.RowIndex;
                int ID = (int)dgView.Rows[row].Cells[0].Value;

                string sql = "DELETE FROM [dbo].[PublicHolidays] WHERE [PublicHolidaysID] = @ID";
                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("刪除成功!!");

                    ReBinding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ooops! 刪除失敗...{ex.Message}");
                }
                finally
                {
                    cn.Dispose();
                }
            }
        }

        /// <summary>
        /// 修改作業
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [dbo].[PublicHolidays] SET [Date] = @Date, [IsHoliday] = @IsHoliday, [Description] = @Description WHERE [PublicHolidaysID] = @ID";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dt_Date.Value;
            cmd.Parameters.Add("@IsHoliday", SqlDbType.Bit).Value = rb_Yes.Checked == true ? 1 : 0;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = rtbx_Description.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = PublicHolidaysID;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("修改資料成功!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 修改資料失敗...{ex.Message}");
            }
            finally
            {
                cn.Dispose();
            }

            ReturnInitial();
            ReBinding();

            btn_Insert.Enabled = true;
            btn_Edit.Enabled = false;
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgView.CurrentCell.RowIndex;
            int ID = (int)dgView.Rows[row].Cells[0].Value;
            PublicHolidaysID = ID;
            string sql = "SELECT PublicHolidaysID, Date, IsHoliday, Description FROM dbo.PublicHolidays WHERE [PublicHolidaysID] = @ID";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dt_Date.Value = (DateTime)dr[1];

                    if (dr[2].ToString() == "False")
                        rb_No.Checked = true;
                    else if (dr[2].ToString() == "True")
                        rb_Yes.Checked = true;

                    rtbx_Description.Text = dr[3].ToString();
                }

                cn.Close();

                MessageBox.Show("獲取資料成功!!");

                btn_Insert.Enabled = false;
                btn_Edit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops! 獲取資料失敗...{ex.Message}");
            }
            finally
            {
                cn.Dispose();
            }
        }
    }
}
