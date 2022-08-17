using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise4
{
    public partial class StarUp : Form
    {
        public StarUp()
        {
            InitializeComponent();
        }

        private async void StarUp_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(50);
/*                loadLable.Text = "Loading " + i + "%";
*/                progressBar1.Value = i;
            }
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            this.Close();
        }

       
    }
}
