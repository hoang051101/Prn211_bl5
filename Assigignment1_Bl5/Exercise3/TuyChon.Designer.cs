namespace Exercise3
{
    partial class TuyChon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbcnn = new System.Windows.Forms.RadioButton();
            this.rducln = new System.Windows.Forms.RadioButton();
            this.rdbacnhat = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btok = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần nhập";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(75, 74);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(169, 27);
            this.txtb.TabIndex = 3;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(75, 30);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(169, 27);
            this.txta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbcnn);
            this.groupBox2.Controls.Add(this.rducln);
            this.groupBox2.Controls.Add(this.rdbacnhat);
            this.groupBox2.Location = new System.Drawing.Point(355, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các tùy chọn tính toán";
            // 
            // rdbcnn
            // 
            this.rdbcnn.AutoSize = true;
            this.rdbcnn.Location = new System.Drawing.Point(6, 86);
            this.rdbcnn.Name = "rdbcnn";
            this.rdbcnn.Size = new System.Drawing.Size(158, 24);
            this.rdbcnn.TabIndex = 6;
            this.rdbcnn.TabStop = true;
            this.rdbcnn.Text = "Bội chung nhỏ nhất";
            this.rdbcnn.UseVisualStyleBackColor = true;
            // 
            // rducln
            // 
            this.rducln.AutoSize = true;
            this.rducln.Location = new System.Drawing.Point(6, 56);
            this.rducln.Name = "rducln";
            this.rducln.Size = new System.Drawing.Size(159, 24);
            this.rducln.TabIndex = 5;
            this.rducln.TabStop = true;
            this.rducln.Text = "Ước chung lớn nhất";
            this.rducln.UseVisualStyleBackColor = true;
            // 
            // rdbacnhat
            // 
            this.rdbacnhat.AutoSize = true;
            this.rdbacnhat.Location = new System.Drawing.Point(6, 26);
            this.rdbacnhat.Name = "rdbacnhat";
            this.rdbacnhat.Size = new System.Drawing.Size(137, 24);
            this.rdbacnhat.TabIndex = 4;
            this.rdbacnhat.TabStop = true;
            this.rdbacnhat.Text = "Giải PT bậc nhất";
            this.rdbacnhat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(39, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 125);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tính toán";
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(39, 204);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(94, 29);
            this.btok.TabIndex = 2;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(195, 204);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(94, 29);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(355, 204);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(94, 29);
            this.btexit.TabIndex = 4;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(511, 204);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(94, 29);
            this.btnext.TabIndex = 5;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // TuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TuyChon";
            this.Text = "TuyChon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbcnn;
        private System.Windows.Forms.RadioButton rducln;
        private System.Windows.Forms.RadioButton rdbacnhat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btnext;
    }
}