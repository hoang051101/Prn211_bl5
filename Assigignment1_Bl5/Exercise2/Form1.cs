using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            txtcode.Text += s;

        }



        private void btthang_Click(object sender, EventArgs e)
        {
            string s = txtcode.Text;
            switch (s)
            {
                case "1645":
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Customer\n";
                        txtcode.Text = "";
                        break;
                    }
                case "1689":
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Technicians\n";
                        txtcode.Text = "";
                        break;
                    }
                case "8345":
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Custodians\n";
                        txtcode.Text = "";
                        break;
                    }
                case "9998":
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Person in charge\n";
                        txtcode.Text = "";
                        break;
                    }
                case "1006":
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Owner\n";
                        txtcode.Text = "";
                        break;
                    }
                case "1008":
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Scientist\n";
                        txtcode.Text = "";
                        break;
                    }
                default:
                    {
                        lbxaccess.Text += " " + DateTime.Now + " Restricted Access!\n";
                        txtcode.Text = "";
                        break;
                    }
            }
        }

        private void btc_Click(object sender, EventArgs e)
        {
            string s = txtcode.Text;
            if (s.Length >= 0)
            {
                txtcode.Text = txtcode.Text.Substring(0, s.Length - 1);
            }
        }

        private void lbxaccess_TextChanged(object sender, EventArgs e)
        {
            lbxaccess.SelectionStart = lbxaccess.Text.Length;
            lbxaccess.ScrollToCaret();
            lbxaccess.Refresh();
        }
    }
}
