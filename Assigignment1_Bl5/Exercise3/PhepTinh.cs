﻿using System;
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
    }
}
