using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigignment1_Bl5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("May chac chan chua?", "Minh Hoang", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bttinhtien_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            if (name == null)
            {
                MessageBox.Show("Chưa nhập tên khách thì tính tiền kiểu gì?");
                this.Show();
            }
            else
            {
                int total = 0;
                if(caovoichk.Checked == true)
                {
                    total += 100000;
                }else if(taytrangchk.Checked == true)
                {
                    total += 1200000;
                }else if(chupchk.Checked == true)
                {
                    total += 200000;
                }
                return ;
            }
        }
    }
}
