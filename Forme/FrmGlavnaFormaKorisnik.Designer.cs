namespace Forme
{
    partial class FrmGlavnaFormaKorisnik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavnaFormaKorisnik));
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.btnUnesiOcenu = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmovi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFilmovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFilmovi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFilmovi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFilmovi.ColumnHeadersHeight = 30;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilmovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilmovi.EnableHeadersVisualStyles = false;
            this.dgvFilmovi.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvFilmovi.Location = new System.Drawing.Point(10, 231);
            this.dgvFilmovi.Name = "dgvFilmovi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFilmovi.RowHeadersVisible = false;
            this.dgvFilmovi.RowHeadersWidth = 25;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.Size = new System.Drawing.Size(412, 163);
            this.dgvFilmovi.TabIndex = 27;
            // 
            // btnUnesiOcenu
            // 
            this.btnUnesiOcenu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUnesiOcenu.FlatAppearance.BorderSize = 0;
            this.btnUnesiOcenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesiOcenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiOcenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnesiOcenu.Location = new System.Drawing.Point(10, 413);
            this.btnUnesiOcenu.Name = "btnUnesiOcenu";
            this.btnUnesiOcenu.Size = new System.Drawing.Size(412, 29);
            this.btnUnesiOcenu.TabIndex = 26;
            this.btnUnesiOcenu.Text = "Unesi ocenu za film";
            this.btnUnesiOcenu.UseVisualStyleBackColor = false;
            this.btnUnesiOcenu.Click += new System.EventHandler(this.btnUnesiOcenu_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(317, 179);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(105, 29);
            this.btnPretrazi.TabIndex = 25;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.BackColor = System.Drawing.SystemColors.Control;
            this.lblPretrazi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretrazi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPretrazi.Location = new System.Drawing.Point(12, 165);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(77, 15);
            this.lblPretrazi.TabIndex = 24;
            this.lblPretrazi.Text = "Pretraži film ";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.BackColor = System.Drawing.SystemColors.Control;
            this.txtPretrazi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretrazi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretrazi.Location = new System.Drawing.Point(10, 187);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(298, 19);
            this.txtPretrazi.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(10, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 1);
            this.panel2.TabIndex = 22;
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
            this.panel1.TabIndex = 21;
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
            // FrmGlavnaFormaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.btnUnesiOcenu);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGlavnaFormaKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGlavnaFormaKorisnik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Button btnUnesiOcenu;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}