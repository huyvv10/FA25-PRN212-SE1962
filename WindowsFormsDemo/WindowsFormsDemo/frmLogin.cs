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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) &&
                    !string.IsNullOrEmpty(txtPass.Text))
                if (txtUserName.Text.Trim() == "vuhuy" && txtPass.Text.Trim() == "321")
                {
                    frmTinhToan frmTT = new frmTinhToan();
                    this.Hide();
                    frmTT.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid user or password","Error",MessageBoxButtons.OK);

           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPass.Text = "";
            txtUserName.Focus();
        }
    }
}
