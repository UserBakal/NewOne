using NEWONE.AppData;
using NEWONE.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NEWONE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       

        private void Form4_Load(object sender, EventArgs e)
        {
            loadgrid();
        }
        public void loadgrid()
        {
            UserInfo userInfo = new UserInfo();
            grid2.DataSource = userInfo.combinedViews1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            UserInfo userInfo = new UserInfo();
            var filteredData = userInfo.combinedViews1()
                                  .Where(row => row.PSITS_Officers.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                                  .ToList();

            grid2.DataSource = filteredData;
        }


    }
}
