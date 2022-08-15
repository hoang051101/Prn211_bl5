using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("May chac chan chua?", "Minh Hoang", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != string.Empty && txtpass.Text != string.Empty)
            {
                if (txtusername.Text == "Admin" || txtusername.Text == "admin")
                {
                    if (txtpass.Text == "123456")
                    {
                        PhepTinh p = new PhepTinh();
                        p.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("UserName or PassWord is wrong! Try again later.");
                }

            }
            else
                MessageBox.Show("Ban hay nhap vao tai khoan va mat khau.");
        }
    }
}
