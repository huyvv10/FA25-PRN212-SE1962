using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtYOB.Text = "";
            cboCourse.SelectedIndex = 0;
            txtId.Focus();
        }

        List<Student> stdList = new List<Student>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            string name = txtName.Text.Trim();
            int yob =int.Parse(txtYOB.Text.Trim());
            string gen = radioButtonNam.Checked ? "Name" : "Nữ";
            string course = cboCourse.Text.Trim();

            Student std = new Student(id, name, yob,gen,course);
            stdList.Add(std);
            SetData();

        }

        public void SetData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = stdList;            
        }
    }
}
