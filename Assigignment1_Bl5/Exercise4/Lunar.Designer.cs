namespace Exercise4
{
    partial class Lunar
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
            this.txtduonglich = new System.Windows.Forms.TextBox();
            this.txtamlich = new System.Windows.Forms.TextBox();
            this.btview = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình đổi năm dương lịch sang âm lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm dương lịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm âm lịch";
            // 
            // txtduonglich
            // 
            this.txtduonglich.Location = new System.Drawing.Point(232, 96);
            this.txtduonglich.Name = "txtduonglich";
            this.txtduonglich.Size = new System.Drawing.Size(160, 27);
            this.txtduonglich.TabIndex = 3;
            // 
            // txtamlich
            // 
            this.txtamlich.Location = new System.Drawing.Point(232, 183);
            this.txtamlich.Name = "txtamlich";
            this.txtamlich.Size = new System.Drawing.Size(160, 27);
            this.txtamlich.TabIndex = 4;
            // 
            // btview
            // 
            this.btview.Location = new System.Drawing.Point(96, 251);
            this.btview.Name = "btview";
            this.btview.Size = new System.Drawing.Size(94, 29);
            this.btview.TabIndex = 5;
            this.btview.Text = "View";
            this.btview.UseVisualStyleBackColor = true;
            this.btview.Click += new System.EventHandler(this.btview_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(263, 251);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(94, 29);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // Lunar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btview);
            this.Controls.Add(this.txtamlich);
            this.Controls.Add(this.txtduonglich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lunar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtduonglich;
        private System.Windows.Forms.TextBox txtamlich;
        private System.Windows.Forms.Button btview;
        private System.Windows.Forms.Button btexit;
    }
}
