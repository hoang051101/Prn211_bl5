namespace Exercise4
{
    partial class frmMain
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
            this.rdmu = new System.Windows.Forms.RadioButton();
            this.rdmc = new System.Windows.Forms.RadioButton();
            this.rdchel = new System.Windows.Forms.RadioButton();
            this.rdtot = new System.Windows.Forms.RadioButton();
            this.rdliver = new System.Windows.Forms.RadioButton();
            this.rdwolver = new System.Windows.Forms.RadioButton();
            this.btthoat = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo các đội bóng nổi tiếng";
            // 
            // rdmu
            // 
            this.rdmu.AutoSize = true;
            this.rdmu.Location = new System.Drawing.Point(64, 82);
            this.rdmu.Name = "rdmu";
            this.rdmu.Size = new System.Drawing.Size(148, 24);
            this.rdmu.TabIndex = 1;
            this.rdmu.TabStop = true;
            this.rdmu.Text = "Mancheter United";
            this.rdmu.UseVisualStyleBackColor = true;
            this.rdmu.CheckedChanged += new System.EventHandler(this.rdmu_CheckedChanged);
            // 
            // rdmc
            // 
            this.rdmc.AutoSize = true;
            this.rdmc.Location = new System.Drawing.Point(64, 149);
            this.rdmc.Name = "rdmc";
            this.rdmc.Size = new System.Drawing.Size(129, 24);
            this.rdmc.TabIndex = 2;
            this.rdmc.TabStop = true;
            this.rdmc.Text = "Mancheter City";
            this.rdmc.UseVisualStyleBackColor = true;
            this.rdmc.CheckedChanged += new System.EventHandler(this.rdmc_CheckedChanged);
            // 
            // rdchel
            // 
            this.rdchel.AutoSize = true;
            this.rdchel.Location = new System.Drawing.Point(64, 218);
            this.rdchel.Name = "rdchel";
            this.rdchel.Size = new System.Drawing.Size(81, 24);
            this.rdchel.TabIndex = 3;
            this.rdchel.TabStop = true;
            this.rdchel.Text = "Chelsea";
            this.rdchel.UseVisualStyleBackColor = true;
            this.rdchel.CheckedChanged += new System.EventHandler(this.rdchel_CheckedChanged);
            // 
            // rdtot
            // 
            this.rdtot.AutoSize = true;
            this.rdtot.Location = new System.Drawing.Point(521, 218);
            this.rdtot.Name = "rdtot";
            this.rdtot.Size = new System.Drawing.Size(153, 24);
            this.rdtot.TabIndex = 4;
            this.rdtot.TabStop = true;
            this.rdtot.Text = "Totenham Hostpur";
            this.rdtot.UseVisualStyleBackColor = true;
            this.rdtot.CheckedChanged += new System.EventHandler(this.rdtot_CheckedChanged);
            // 
            // rdliver
            // 
            this.rdliver.AutoSize = true;
            this.rdliver.Location = new System.Drawing.Point(521, 273);
            this.rdliver.Name = "rdliver";
            this.rdliver.Size = new System.Drawing.Size(92, 24);
            this.rdliver.TabIndex = 5;
            this.rdliver.TabStop = true;
            this.rdliver.Text = "Liverpool";
            this.rdliver.UseVisualStyleBackColor = true;
            this.rdliver.CheckedChanged += new System.EventHandler(this.rdliver_CheckedChanged);
            // 
            // rdwolver
            // 
            this.rdwolver.AutoSize = true;
            this.rdwolver.Location = new System.Drawing.Point(521, 334);
            this.rdwolver.Name = "rdwolver";
            this.rdwolver.Size = new System.Drawing.Size(136, 24);
            this.rdwolver.TabIndex = 6;
            this.rdwolver.TabStop = true;
            this.rdwolver.Text = "Wolverhampton";
            this.rdwolver.UseVisualStyleBackColor = true;
            this.rdwolver.CheckedChanged += new System.EventHandler(this.rdwolver_CheckedChanged);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(64, 295);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(94, 29);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(323, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(257, 200);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.rdwolver);
            this.Controls.Add(this.rdliver);
            this.Controls.Add(this.rdtot);
            this.Controls.Add(this.rdchel);
            this.Controls.Add(this.rdmc);
            this.Controls.Add(this.rdmu);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdmu;
        private System.Windows.Forms.RadioButton rdmc;
        private System.Windows.Forms.RadioButton rdchel;
        private System.Windows.Forms.RadioButton rdtot;
        private System.Windows.Forms.RadioButton rdliver;
        private System.Windows.Forms.RadioButton rdwolver;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}