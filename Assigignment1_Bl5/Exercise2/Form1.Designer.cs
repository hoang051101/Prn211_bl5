namespace Exercise2
{
    partial class Form1
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
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btthang = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.lbxaccess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Code";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(106, 27);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '*';
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(151, 23);
            this.txtcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access log";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(60, 76);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(32, 23);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.number_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(60, 115);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(32, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.number_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(60, 154);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(32, 23);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.number_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(98, 154);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(32, 23);
            this.bt8.TabIndex = 7;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.number_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(136, 154);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(32, 23);
            this.bt9.TabIndex = 8;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.number_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(174, 154);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(32, 23);
            this.bt0.TabIndex = 9;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.number_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(98, 115);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(32, 23);
            this.bt5.TabIndex = 10;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.number_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(136, 115);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(32, 23);
            this.bt6.TabIndex = 11;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.number_Click);
            // 
            // btthang
            // 
            this.btthang.BackColor = System.Drawing.Color.Fuchsia;
            this.btthang.Location = new System.Drawing.Point(174, 115);
            this.btthang.Name = "btthang";
            this.btthang.Size = new System.Drawing.Size(32, 23);
            this.btthang.TabIndex = 12;
            this.btthang.Text = "#";
            this.btthang.UseVisualStyleBackColor = false;
            this.btthang.Click += new System.EventHandler(this.btthang_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(98, 76);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(32, 23);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.number_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(136, 76);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(32, 23);
            this.bt3.TabIndex = 14;
            this.bt3.Text = " 3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.number_Click);
            // 
            // btc
            // 
            this.btc.BackColor = System.Drawing.Color.Yellow;
            this.btc.Location = new System.Drawing.Point(174, 76);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(32, 23);
            this.btc.TabIndex = 15;
            this.btc.Text = "C";
            this.btc.UseVisualStyleBackColor = false;
            this.btc.Click += new System.EventHandler(this.btc_Click);
            // 
            // lbxaccess
            // 
            this.lbxaccess.Location = new System.Drawing.Point(48, 232);
            this.lbxaccess.Multiline = true;
            this.lbxaccess.Name = "lbxaccess";
            this.lbxaccess.ReadOnly = true;
            this.lbxaccess.Size = new System.Drawing.Size(209, 123);
            this.lbxaccess.TabIndex = 16;
            this.lbxaccess.TextChanged += new System.EventHandler(this.lbxaccess_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 379);
            this.Controls.Add(this.lbxaccess);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btthang);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btthang;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.TextBox lbxaccess;
    }
}
