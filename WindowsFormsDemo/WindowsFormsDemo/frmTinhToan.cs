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
    public partial class frmTinhToan : Form
    {
        public frmTinhToan()
        {
            InitializeComponent();
        }

        private void btnQuotien_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text.Trim());
            int b = int.Parse(txtB.Text.Trim());
            txtResult.Text = (a + b) +"";
        }

        private void btnStd_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent = new frmStudent();
            this.Hide();
            frmStudent.ShowDialog();
            this.Close();
        }
    }
}
