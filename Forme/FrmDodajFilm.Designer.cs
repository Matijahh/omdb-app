namespace Forme
{
    partial class FrmDodajFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajFilm));
            this.lblGodina = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKorisnikIme = new System.Windows.Forms.Label();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.BackColor = System.Drawing.Color.Transparent;
            this.lblGodina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodina.ForeColor = System.Drawing.Color.DimGray;
            this.lblGodina.Location = new System.Drawing.Point(38, 294);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(67, 19);
            this.lblGodina.TabIndex = 35;
            this.lblGodina.Text = "Godina : ";
            // 
            // txtGodina
            // 
            this.txtGodina.BackColor = System.Drawing.SystemColors.Control;
            this.txtGodina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGodina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.Location = new System.Drawing.Point(40, 316);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(350, 19);
            this.txtGodina.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(40, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 1);
            this.panel3.TabIndex = 36;
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivFilma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivFilma.ForeColor = System.Drawing.Color.DimGray;
            this.lblNazivFilma.Location = new System.Drawing.Point(38, 206);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(92, 19);
            this.lblNazivFilma.TabIndex = 31;
            this.lblNazivFilma.Text = "Naziv filma : ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodaj.Location = new System.Drawing.Point(135, 389);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(156, 29);
            this.btnDodaj.TabIndex = 34;
            this.btnDodaj.Text = "Dodaj film";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.SystemColors.Control;
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(40, 228);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(350, 19);
            this.txtNaziv.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(40, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 1);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblKorisnikIme);
            this.panel1.Controls.Add(this.btnOdjaviSe);
            this.panel1.Controls.Add(this.lblKorisnik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 150);
            this.panel1.TabIndex = 30;
            // 
            // lblKorisnikIme
            // 
            this.lblKorisnikIme.AutoSize = true;
            this.lblKorisnikIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnikIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnikIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKorisnikIme.Location = new System.Drawing.Point(107, 124);
            this.lblKorisnikIme.Name = "lblKorisnikIme";
            this.lblKorisnikIme.Size = new System.Drawing.Size(0, 19);
            this.lblKorisnikIme.TabIndex = 14;
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
            this.btnOdjaviSe.Text = "Izađi";
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
            this.lblKorisnik.Size = new System.Drawing.Size(109, 19);
            this.lblKorisnik.TabIndex = 9;
            this.lblKorisnik.Text = "Administrator : ";
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
            // FrmDodajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblNazivFilma);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodajFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDodajFilm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKorisnikIme;
    }
}