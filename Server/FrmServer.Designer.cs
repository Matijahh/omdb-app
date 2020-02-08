namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.btnPokreniServer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblServerStanje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPokreniServer.FlatAppearance.BorderSize = 0;
            this.btnPokreniServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreniServer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreniServer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPokreniServer.Location = new System.Drawing.Point(13, 206);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(123, 31);
            this.btnPokreniServer.TabIndex = 11;
            this.btnPokreniServer.Text = "Pokreni server";
            this.btnPokreniServer.UseVisualStyleBackColor = false;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblServerStanje);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 190);
            this.panel1.TabIndex = 10;
            // 
            // lblServerStanje
            // 
            this.lblServerStanje.AutoSize = true;
            this.lblServerStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblServerStanje.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStanje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServerStanje.Location = new System.Drawing.Point(3, 0);
            this.lblServerStanje.Name = "lblServerStanje";
            this.lblServerStanje.Size = new System.Drawing.Size(75, 13);
            this.lblServerStanje.TabIndex = 9;
            this.lblServerStanje.Text = "Stanje servera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnZaustavi.FlatAppearance.BorderSize = 0;
            this.btnZaustavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaustavi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZaustavi.Location = new System.Drawing.Point(165, 207);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(123, 31);
            this.btnZaustavi.TabIndex = 12;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = false;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreniServer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServer";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPokreniServer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblServerStanje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnZaustavi;
    }
}

