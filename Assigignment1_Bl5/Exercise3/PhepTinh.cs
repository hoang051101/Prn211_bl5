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
    public partial class PhepTinh : Form
    {
        public PhepTinh()
        {
            InitializeComponent();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            TuyChon tc = new TuyChon();
            tc.Show();
            this.Hide();
            
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txta.Text = String.Empty;
            txtb.Text = String.Empty;
        }

        private void btthuchien_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txta.Text.Trim()) || String.IsNullOrEmpty(txtb.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("enter a number", "System", MessageBoxButtons.OK);
            }
            else
            {
                caculate();

            }
        }

        private void caculate()
        {
            string option = Convert.ToString(cbpheptinh.Text.Trim());
            float kq =0;
            switch (option)
            {
                case "Cộng":
                    kq = Convert.ToInt32(txta.Text) + Convert.ToInt32(txtb.Text);
                    break;
                case "Trừ":
                    kq = Convert.ToInt32(txta.Text) - Convert.ToInt32(txtb.Text);
                    break;
                case "Nhân":
                    kq = Convert.ToInt32(txta.Text) * Convert.ToInt32(txtb.Text);
                    break;
                case "Chia":
                    if (Convert.ToInt32(txtb.Text) != 0)
                    {
                        kq = Convert.ToInt32(txta.Text) / Convert.ToInt32(txtb.Text);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    break;

            }
            txtketqua.Text = kq.ToString();
        }
    }
}
