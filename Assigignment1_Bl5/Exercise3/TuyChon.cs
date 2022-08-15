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

namespace Exercise3
{
    public partial class TuyChon : Form
    {
        public TuyChon()
        {
            InitializeComponent();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            rd.Show();
            this.Hide();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("May chac chan chua?", "SYSTEM", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txta.Text = string.Empty;
            txtb.Text = string.Empty;
        }

        private void btok_Click(object sender, EventArgs e)
        {
            int a, b;
            if (String.IsNullOrEmpty(txta.Text.Trim()) || String.IsNullOrEmpty(txtb.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Chua nhap a, b", "Minh Hoang", MessageBoxButtons.OK);
            }
            else if(!int.TryParse(txta.Text, out a) || !int.TryParse(txtb.Text, out b)) 
            {
                MessageBox.Show("Nhap dung so a, b di thi moi tinh duoc");
            }
            else
            {
                if (rdbacnhat.Checked == true)
                {
                    GiaiPTBacNhat();
                }
                else if (rdbcnn.Checked == true)
                {
                    txtkq.Text = BCNN(a, b).ToString();
                }
                else if (rducln.Checked == true)
                {
                    txtkq.Text = UCLN(a,b).ToString();
                }
            }
        }
        //su dung de qui
        public int UCLN(int a, int b)
        {
            return b == 0 ? a : UCLN(b, a % b);
        }

        public int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);
        }

        private void GiaiPTBacNhat()
        {

            if (Convert.ToInt32(txta.Text) == 0)
            {
                if (Convert.ToInt32(txtb.Text) == 0)
                {

                    MessageBox.Show("Phuong trinh vo so nghiem");
                }
                else
                {
                    MessageBox.Show("Phuong trinh vo nghiem");
                }
            }
            else
            {
                float kq = 0;
                kq = -int.Parse(txtb.Text) / int.Parse(txta.Text);
                txtkq.Text = kq.ToString();
            }

        }
    }
}
