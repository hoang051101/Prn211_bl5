namespace Exercise3
{
    partial class Random
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
            this.btplay = new System.Windows.Forms.Button();
            this.nmrsinhvien = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btplay
            // 
            this.btplay.Location = new System.Drawing.Point(112, 227);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(94, 29);
            this.btplay.TabIndex = 0;
            this.btplay.Text = "PLAY";
            this.btplay.UseVisualStyleBackColor = true;
            // 
            // nmrsinhvien
            // 
            this.nmrsinhvien.Location = new System.Drawing.Point(154, 289);
            this.nmrsinhvien.Name = "nmrsinhvien";
            this.nmrsinhvien.Size = new System.Drawing.Size(150, 27);
            this.nmrsinhvien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn số sinh viên:";
            // 
            // Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrsinhvien);
            this.Controls.Add(this.btplay);
            this.Name = "Random";
            this.Text = "Random";
            ((System.ComponentModel.ISupportInitialize)(this.nmrsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.NumericUpDown nmrsinhvien;
        private System.Windows.Forms.Label label1;
    }
}