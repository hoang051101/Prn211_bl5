namespace Exercise3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblogin = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.rdvi = new System.Windows.Forms.RadioButton();
            this.rden = new System.Windows.Forms.RadioButton();
            this.btlogin = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.linkforget = new System.Windows.Forms.LinkLabel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblogin.ForeColor = System.Drawing.Color.Red;
            this.lblogin.Location = new System.Drawing.Point(221, 32);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(95, 41);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "Login";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(79, 119);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(82, 20);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "User Name";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(79, 176);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(72, 20);
            this.lbpass.TabIndex = 2;
            this.lbpass.Text = "PassWord";
            // 
            // rdvi
            // 
            this.rdvi.AutoSize = true;
            this.rdvi.Location = new System.Drawing.Point(360, 16);
            this.rdvi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdvi.Name = "rdvi";
            this.rdvi.Size = new System.Drawing.Size(43, 24);
            this.rdvi.TabIndex = 3;
            this.rdvi.TabStop = true;
            this.rdvi.Text = "VI";
            this.rdvi.UseVisualStyleBackColor = true;
            this.rdvi.CheckedChanged += new System.EventHandler(this.rdvi_CheckedChanged);
            // 
            // rden
            // 
            this.rden.AutoSize = true;
            this.rden.Location = new System.Drawing.Point(451, 16);
            this.rden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rden.Name = "rden";
            this.rden.Size = new System.Drawing.Size(49, 24);
            this.rden.TabIndex = 4;
            this.rden.TabStop = true;
            this.rden.Text = "EN";
            this.rden.UseVisualStyleBackColor = true;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(79, 225);
            this.btlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(124, 31);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(221, 225);
            this.btreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(107, 31);
            this.btreset.TabIndex = 6;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(352, 225);
            this.btexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(110, 31);
            this.btexit.TabIndex = 7;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // linkforget
            // 
            this.linkforget.AutoSize = true;
            this.linkforget.Location = new System.Drawing.Point(209, 285);
            this.linkforget.Name = "linkforget";
            this.linkforget.Size = new System.Drawing.Size(119, 20);
            this.linkforget.TabIndex = 8;
            this.linkforget.TabStop = true;
            this.linkforget.Text = "Forget password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(189, 112);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(271, 27);
            this.txtusername.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(190, 165);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(271, 27);
            this.txtpass.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 317);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.linkforget);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.rden);
            this.Controls.Add(this.rdvi);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.lblogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.RadioButton rdvi;
        private System.Windows.Forms.RadioButton rden;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        protected System.Windows.Forms.LinkLabel linkforget;
    }
}
