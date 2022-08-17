using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void rdmu_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = @"..\..\..\..\Imgage\mu.jpg";
        }

        private void rdmc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdchel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdtot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdliver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdwolver_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
