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
    }
}
