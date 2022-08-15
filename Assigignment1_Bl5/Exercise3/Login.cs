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

        private void rdvi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdvi.Checked == true)
            {
                rdvi.Text = " Việt";
                rden.Text = "Anh";
                lblogin.Text = "Đăng nhập";
                lbusername.Text = "Tên đăng nhập";
                lbpass.Text = "Mật khẩu";
                linkforget.Text = "Quên mật khẩu";
                btlogin.Text = "Đăng nhập";
                btexit.Text = "Thoát";
                btreset.Text = "Hủy";
            }
            else
            {
                rdvi.Text = " VI";
                rden.Text = "EN";
                lblogin.Text = "Login";
                lbusername.Text = "User Name";
                lbpass.Text = "Pass word";
                linkforget.Text = "Forget password";
                btlogin.Text = "Login";
                btexit.Text = "Exit";
                btreset.Text = "Reset";
            }

        }

        
    }
}
