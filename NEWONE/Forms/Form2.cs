using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEWONE.AppData;
using NEWONE.AppData;


namespace NEWONE
{
    public partial class Form2 : Form
    {
        DBSysProjEntities2 db;
        public Form2()
        {
            InitializeComponent();
            db = new DBSysProjEntities2();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            loadOfficer();
            loadEvents();
        }

        private void loadOfficer()
        {
            using (db = new DBSysProjEntities2())
            { 
                var officer = db.PSITS.ToList();

                cbOfficer.ValueMember = "psitsID";
                cbOfficer.DisplayMember = "Position";
                cbOfficer.DataSource = officer;
            }
        }
        private void loadEvents() 
        {
            using (db = new DBSysProjEntities2())
                {
                    var Events = db.Event.ToList();

                    cbEvents.ValueMember = "EventID";
                    cbEvents.DisplayMember = "EventName";
                    cbEvents.DataSource = Events;
                    
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbOfficer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (db = new DBSysProjEntities2())
            {
                if (String.IsNullOrEmpty(txtIdNum.Text))
                {
                    errorProvider1.SetError(txtIdNum, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtFirstName.Text))
                {
                    errorProvider1.SetError(txtFirstName, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtLastName.Text))
                {
                    errorProvider1.SetError(txtLastName, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtCourse.Text))
                {
                    errorProvider1.SetError(txtCourse, "Empty Field");
                    return;
                }
               

                Student nstudent = new Student();
                nstudent.IDNumber = Convert.ToInt32(txtIdNum.Text);
                nstudent.FirstName = txtFirstName.Text;
                nstudent.LastName = txtLastName.Text;
                nstudent.Course = txtCourse.Text;
                nstudent.psitsId = cbOfficer.SelectedIndex + 1;
                nstudent.eventId = cbEvents.SelectedIndex + 1;

                db.Student.Add(nstudent);
                db.SaveChanges();

                cbOfficer.SelectedIndex = 0;
                cbEvents.SelectedIndex = 0;
                txtFirstName.Clear();
                txtLastName.Clear();
                txtCourse.Clear();
                txtIdNum.Clear();
                MessageBox.Show("Registered!");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
