using NEWONE.Repositories;
using NEWONE.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEWONE.Model;
using NEWONE.Repositories;

namespace NEWONE
{
    public partial class Form3 : Form
    {
        UserInfo userInfo;
        public Form3()
        {
            InitializeComponent();
            userInfo = new UserInfo();
        }
        public void loadgrid()
        {
            UserInfo userInfo = new UserInfo();
            grid2.DataSource = userInfo.vw_ViewPsits();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String studentId = txtStudentId.Text;

            String strOutputMsg = "";
            if (String.IsNullOrEmpty(txtStudentId.Text))
            {
                errorProviderCustom.SetError(txtStudentId, "Empty Field");
                return;
            }
            ErrorCode retValue = userInfo.DeletePsitsUsingStoredProf(Convert.ToInt32(studentId), ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadgrid();

                txtStudentId.Text = "";
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentId.Text = grid2.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
