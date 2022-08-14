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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PassWord";
            // 
            // rdvi
            // 
            this.rdvi.AutoSize = true;
            this.rdvi.Location = new System.Drawing.Point(355, 12);
            this.rdvi.Name = "rdvi";
            this.rdvi.Size = new System.Drawing.Size(35, 19);
            this.rdvi.TabIndex = 3;
            this.rdvi.TabStop = true;
            this.rdvi.Text = "VI";
            this.rdvi.UseVisualStyleBackColor = true;
            // 
            // rden
            // 
            this.rden.AutoSize = true;
            this.rden.Location = new System.Drawing.Point(396, 12);
            this.rden.Name = "rden";
            this.rden.Size = new System.Drawing.Size(40, 19);
            this.rden.TabIndex = 4;
            this.rden.TabStop = true;
            this.rden.Text = "EN";
            this.rden.UseVisualStyleBackColor = true;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(69, 169);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(193, 169);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 6;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(315, 169);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 7;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // linkforget
            // 
            this.linkforget.AutoSize = true;
            this.linkforget.Location = new System.Drawing.Point(183, 214);
            this.linkforget.Name = "linkforget";
            this.linkforget.Size = new System.Drawing.Size(94, 15);
            this.linkforget.TabIndex = 8;
            this.linkforget.TabStop = true;
            this.linkforget.Text = "Forget password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(152, 81);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(238, 23);
            this.txtusername.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(152, 124);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(238, 23);
            this.txtpass.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 238);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.linkforget);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.rden);
            this.Controls.Add(this.rdvi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdvi;
        private System.Windows.Forms.RadioButton rden;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.LinkLabel linkforget;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
    }
}
