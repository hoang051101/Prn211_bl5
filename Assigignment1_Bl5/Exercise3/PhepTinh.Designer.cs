namespace Exercise3
{
    partial class PhepTinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbpheptinh = new System.Windows.Forms.ComboBox();
            this.btthuchien = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực hiện phép tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập b";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(157, 124);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(288, 27);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(157, 205);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(288, 27);
            this.txtb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chọn phép tính";
            // 
            // cbpheptinh
            // 
            this.cbpheptinh.FormattingEnabled = true;
            this.cbpheptinh.Location = new System.Drawing.Point(222, 270);
            this.cbpheptinh.Name = "cbpheptinh";
            this.cbpheptinh.Size = new System.Drawing.Size(180, 28);
            this.cbpheptinh.TabIndex = 6;
            // 
            // btthuchien
            // 
            this.btthuchien.Location = new System.Drawing.Point(76, 336);
            this.btthuchien.Name = "btthuchien";
            this.btthuchien.Size = new System.Drawing.Size(94, 29);
            this.btthuchien.TabIndex = 7;
            this.btthuchien.Text = "Thực hiện";
            this.btthuchien.UseVisualStyleBackColor = true;
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(209, 336);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(94, 29);
            this.btreset.TabIndex = 8;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(351, 336);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(94, 29);
            this.btnext.TabIndex = 9;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "--> Kết quả";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(193, 400);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.ReadOnly = true;
            this.txtketqua.Size = new System.Drawing.Size(252, 27);
            this.txtketqua.TabIndex = 11;
            // 
            // PhepTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 487);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btthuchien);
            this.Controls.Add(this.cbpheptinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhepTinh";
            this.Text = "PhepTinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbpheptinh;
        private System.Windows.Forms.Button btthuchien;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtketqua;
    }
}