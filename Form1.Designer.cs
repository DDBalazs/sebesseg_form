namespace sebesseg_formm
{
    partial class Form1
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
            this.btszam = new System.Windows.Forms.Button();
            this.btkilep = new System.Windows.Forms.Button();
            this.lbut = new System.Windows.Forms.Label();
            this.lbido = new System.Windows.Forms.Label();
            this.lbseb = new System.Windows.Forms.Label();
            this.lbkmo = new System.Windows.Forms.Label();
            this.lbora = new System.Windows.Forms.Label();
            this.lbkm = new System.Windows.Forms.Label();
            this.txut = new System.Windows.Forms.TextBox();
            this.txido = new System.Windows.Forms.TextBox();
            this.txseb = new System.Windows.Forms.TextBox();
            this.lbhaha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btszam
            // 
            this.btszam.Location = new System.Drawing.Point(59, 239);
            this.btszam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btszam.Name = "btszam";
            this.btszam.Size = new System.Drawing.Size(128, 58);
            this.btszam.TabIndex = 0;
            this.btszam.Text = "Számol";
            this.btszam.UseVisualStyleBackColor = true;
            this.btszam.Click += new System.EventHandler(this.btszam_Click);
            // 
            // btkilep
            // 
            this.btkilep.Location = new System.Drawing.Point(254, 239);
            this.btkilep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btkilep.Name = "btkilep";
            this.btkilep.Size = new System.Drawing.Size(128, 58);
            this.btkilep.TabIndex = 1;
            this.btkilep.Text = "Kilépés";
            this.btkilep.UseVisualStyleBackColor = true;
            this.btkilep.Click += new System.EventHandler(this.btkilep_Click);
            // 
            // lbut
            // 
            this.lbut.AutoSize = true;
            this.lbut.Location = new System.Drawing.Point(56, 63);
            this.lbut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbut.Name = "lbut";
            this.lbut.Size = new System.Drawing.Size(73, 13);
            this.lbut.TabIndex = 2;
            this.lbut.Text = "Megtett út: ";
            // 
            // lbido
            // 
            this.lbido.AutoSize = true;
            this.lbido.Location = new System.Drawing.Point(56, 119);
            this.lbido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbido.Name = "lbido";
            this.lbido.Size = new System.Drawing.Size(29, 13);
            this.lbido.TabIndex = 3;
            this.lbido.Text = "Idő:";
            // 
            // lbseb
            // 
            this.lbseb.AutoSize = true;
            this.lbseb.Location = new System.Drawing.Point(56, 176);
            this.lbseb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbseb.Name = "lbseb";
            this.lbseb.Size = new System.Drawing.Size(70, 13);
            this.lbseb.TabIndex = 4;
            this.lbseb.Text = "Sebesség: ";
            // 
            // lbkmo
            // 
            this.lbkmo.AutoSize = true;
            this.lbkmo.Location = new System.Drawing.Point(302, 176);
            this.lbkmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbkmo.Name = "lbkmo";
            this.lbkmo.Size = new System.Drawing.Size(47, 13);
            this.lbkmo.TabIndex = 7;
            this.lbkmo.Text = "km/óra";
            // 
            // lbora
            // 
            this.lbora.AutoSize = true;
            this.lbora.Location = new System.Drawing.Point(302, 119);
            this.lbora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbora.Name = "lbora";
            this.lbora.Size = new System.Drawing.Size(25, 13);
            this.lbora.TabIndex = 6;
            this.lbora.Text = "óra";
            // 
            // lbkm
            // 
            this.lbkm.AutoSize = true;
            this.lbkm.Location = new System.Drawing.Point(302, 63);
            this.lbkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbkm.Name = "lbkm";
            this.lbkm.Size = new System.Drawing.Size(23, 13);
            this.lbkm.TabIndex = 5;
            this.lbkm.Text = "km";
            // 
            // txut
            // 
            this.txut.Location = new System.Drawing.Point(135, 63);
            this.txut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txut.Name = "txut";
            this.txut.Size = new System.Drawing.Size(159, 20);
            this.txut.TabIndex = 8;
            // 
            // txido
            // 
            this.txido.Location = new System.Drawing.Point(135, 112);
            this.txido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txido.Name = "txido";
            this.txido.Size = new System.Drawing.Size(159, 20);
            this.txido.TabIndex = 9;
            // 
            // txseb
            // 
            this.txseb.Enabled = false;
            this.txseb.Location = new System.Drawing.Point(135, 176);
            this.txseb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txseb.Name = "txseb";
            this.txseb.Size = new System.Drawing.Size(159, 20);
            this.txseb.TabIndex = 10;
            // 
            // lbhaha
            // 
            this.lbhaha.AutoSize = true;
            this.lbhaha.Location = new System.Drawing.Point(197, 217);
            this.lbhaha.Name = "lbhaha";
            this.lbhaha.Size = new System.Drawing.Size(41, 13);
            this.lbhaha.TabIndex = 11;
            this.lbhaha.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 319);
            this.Controls.Add(this.lbhaha);
            this.Controls.Add(this.txseb);
            this.Controls.Add(this.txido);
            this.Controls.Add(this.txut);
            this.Controls.Add(this.lbkmo);
            this.Controls.Add(this.lbora);
            this.Controls.Add(this.lbkm);
            this.Controls.Add(this.lbseb);
            this.Controls.Add(this.lbido);
            this.Controls.Add(this.lbut);
            this.Controls.Add(this.btkilep);
            this.Controls.Add(this.btszam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Sebesség számítás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btszam;
        private System.Windows.Forms.Button btkilep;
        private System.Windows.Forms.Label lbut;
        private System.Windows.Forms.Label lbido;
        private System.Windows.Forms.Label lbseb;
        private System.Windows.Forms.Label lbkmo;
        private System.Windows.Forms.Label lbora;
        private System.Windows.Forms.Label lbkm;
        private System.Windows.Forms.TextBox txut;
        private System.Windows.Forms.TextBox txido;
        private System.Windows.Forms.TextBox txseb;
        private System.Windows.Forms.Label lbhaha;
    }
}

