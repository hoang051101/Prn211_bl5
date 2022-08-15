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
            if (rdbacnhat.Checked == true)
            {
                GiaiPTBacNhat();
            }
            else if (rdbcnn.Checked == true)
            {
                BCNN();
            }
            else if (rducln.Checked == true)
            {
                UCLN();
            }
        }

        private void UCLN()
        {
            if(Convert.ToInt32(txta.Text) == 0 && Convert.ToInt32(txtb.Text) == 0)
            {
                MessageBox.Show("Phuong trinh vo so nghiem");
            }
            if(Convert.ToInt32(txta.Text) == 0 && Convert.ToInt32(txtb.Text) != 0)
            {
                MessageBox.Show("Phuong trinh vo nghiem");
            }
            if(Convert.ToInt32(txta.Text) == 0 && Convert.ToInt32(txtb.Text) == 0)
        }

        private void BCNN()
        {
        }

        private void GiaiPTBacNhat()
        {
        }
    }
}
