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
    public partial class Lunar : Form
    {
        public Lunar()
        {
            InitializeComponent();
        }
        
        string[] chiCheck = { "Thân", "Dậu", "Tuất", "Hợi", "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
        string[] canCheck = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
        
        private void btexit_Click(object sender, EventArgs e)
        {
  
            if (MessageBox.Show("May chac chan chua?", "System", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btview_Click(object sender, EventArgs e)
        {
            try
            {
                int chi = Convert.ToInt32(txtduonglich.Text) % 12;
                int can = Convert.ToInt32(txtduonglich.Text) % 10;
                txtamlich.Text = canCheck[can] + " " + chiCheck[chi];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui long nhap dung nam");
            }
        }
    }
}
