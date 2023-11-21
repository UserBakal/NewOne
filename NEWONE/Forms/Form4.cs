using NEWONE.Model;
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
       
        

    }
}
