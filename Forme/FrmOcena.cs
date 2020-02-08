using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domeni;

namespace Forme
{
    public partial class FrmOcena : Form
    {
        private Film f;
        private string ime;
        private string prezime;

        KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();
        private Korisnik korisnik;

        public FrmOcena()
        {
            InitializeComponent();
        }

        public FrmOcena(Film f, Korisnik korisnik)
        {
            InitializeComponent();
            this.f = f;
            this.korisnik = korisnik;
            kki.PrikaziSveKategorijeCmb(cmbKategorija);
            lblKorisnik.Text += " " + korisnik.Ime + " " + korisnik.Prezime;
            lblFilm.Text += " " + f.Naziv;
        }

        public FrmOcena(Film f, string ime, string prezime)
        {
            InitializeComponent();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnesiOcenu_Click(object sender, EventArgs e)
        {
            kki.SacuvajOcenu(txtOcena, cmbKategorija, korisnik, f);
        }
    }
}
