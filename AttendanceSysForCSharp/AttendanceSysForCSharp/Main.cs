using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSysForCSharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Employee_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_Employee fm = new fm_Employee();
            fm.MdiParent = this;
            fm.Show();
        }

        private void Department_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_Department fm = new fm_Department();
            fm.MdiParent = this;
            fm.Show();
        }

        private void Title_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_Title fm = new fm_Title();
            fm.MdiParent = this;
            fm.Show();
        }

        private void Holidays_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fm_Holidays fm = new fm_Holidays();
            fm.MdiParent = this;
            fm.Show();
        }

        private void PunchCardDay_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_PunchCardDay fm = new fm_PunchCardDay();
            fm.MdiParent = this;
            fm.Show();
        }

        private void PunchCardMonth_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_PunchCardMonth fm = new fm_PunchCardMonth();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
