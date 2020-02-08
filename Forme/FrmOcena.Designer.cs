namespace Forme
{
    partial class FrmOcena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOcena));
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOcena = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnUnesiOcenu = new System.Windows.Forms.Button();
            this.lblFilm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOcena
            // 
            this.txtOcena.BackColor = System.Drawing.SystemColors.Control;
            this.txtOcena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOcena.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcena.Location = new System.Drawing.Point(310, 283);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(80, 19);
            this.txtOcena.TabIndex = 41;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.SystemColors.Control;
            this.lbl10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl10.Location = new System.Drawing.Point(396, 289);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(26, 15);
            this.lbl10.TabIndex = 40;
            this.lbl10.Text = "/10";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(310, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 1);
            this.panel2.TabIndex = 39;
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.BackColor = System.Drawing.SystemColors.Control;
            this.lblOcena.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblOcena.Location = new System.Drawing.Point(226, 289);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(78, 15);
            this.lblOcena.TabIndex = 38;
            this.lblOcena.Text = "Tvoja ocena :";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.BackColor = System.Drawing.SystemColors.Control;
            this.lblKategorija.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblKategorija.Location = new System.Drawing.Point(12, 222);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(70, 15);
            this.lblKategorija.TabIndex = 37;
            this.lblKategorija.Text = "Kategorija :";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.BackColor = System.Drawing.SystemColors.Control;
            this.cmbKategorija.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbKategorija.Location = new System.Drawing.Point(133, 220);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(289, 22);
            this.cmbKategorija.TabIndex = 36;
            // 
            // btnUnesiOcenu
            // 
            this.btnUnesiOcenu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUnesiOcenu.FlatAppearance.BorderSize = 0;
            this.btnUnesiOcenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesiOcenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiOcenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnesiOcenu.Location = new System.Drawing.Point(12, 342);
            this.btnUnesiOcenu.Name = "btnUnesiOcenu";
            this.btnUnesiOcenu.Size = new System.Drawing.Size(412, 29);
            this.btnUnesiOcenu.TabIndex = 35;
            this.btnUnesiOcenu.Text = "Unesi ocenu za film";
            this.btnUnesiOcenu.UseVisualStyleBackColor = false;
            this.btnUnesiOcenu.Click += new System.EventHandler(this.btnUnesiOcenu_Click);
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.BackColor = System.Drawing.SystemColors.Control;
            this.lblFilm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFilm.Location = new System.Drawing.Point(12, 168);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(126, 15);
            this.lblFilm.TabIndex = 34;
            this.lblFilm.Text = "Film koji se ocenjuje : ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnOdjaviSe);
            this.panel1.Controls.Add(this.lblKorisnik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 150);
            this.panel1.TabIndex = 33;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdjaviSe.FlatAppearance.BorderSize = 0;
            this.btnOdjaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjaviSe.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjaviSe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdjaviSe.Location = new System.Drawing.Point(354, 12);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(68, 22);
            this.btnOdjaviSe.TabIndex = 13;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnik.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKorisnik.Location = new System.Drawing.Point(3, 124);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(72, 19);
            this.lblKorisnik.TabIndex = 9;
            this.lblKorisnik.Text = "Korisnik : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOcena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 385);
            this.Controls.Add(this.txtOcena);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnUnesiOcenu);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOcena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOcena";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnUnesiOcenu;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}