using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmDodajFilm : Form
    {
        private KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();
        private string ime;
        private string prezime;

        public FrmDodajFilm()
        {
            InitializeComponent();
        }

        public FrmDodajFilm(string ime, string prezime)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            lblKorisnikIme.Text = ime + " " + prezime;
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kki.SacuvajFilm(txtNaziv, txtGodina, lblKorisnikIme);
        }
    }
}
