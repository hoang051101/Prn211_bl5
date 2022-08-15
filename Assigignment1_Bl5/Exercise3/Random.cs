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
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();

        private void btplay_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(nmrsinhvien.Text);
            if (list.Count == total)
            {
                MessageBox.Show("Running out of options", "System");
            }
            else
            {
                System.Random random = new();
                int randomNumber = random.Next(1, total + 1);
                if (!list.Contains(randomNumber))
                {
                    list.Add(randomNumber);
                }
                else
                {
                    while (list.Contains(randomNumber))
                    {
                        randomNumber = random.Next(1, total + 1);
                    }
                    list.Add(randomNumber);
                }
                txtNumber.Text = randomNumber.ToString();
            }
        }

        private void nmrsinhvien_ValueChanged(object sender, EventArgs e)
        {
            list.Clear();
        }
    }
}

