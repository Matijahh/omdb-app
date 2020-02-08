using Domeni;
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
    public partial class FrmGlavnaFormaAdmin : Form
    {
        KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();

        public FrmGlavnaFormaAdmin()
        {
            InitializeComponent();
            lblKorisnik.Text += " " + Sesija.Instance.Admin.Ime + " " + Sesija.Instance.Admin.Prezime;
            kki.PrikaziSveFilmove(dgvFilmovi);
            kki.PrikaziSveKategorije(dgvKategorije);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kki.PrikaziFilmove(dgvFilmovi, txtPretrazi);
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmDodajFilm(Sesija.Instance.Admin.Ime, Sesija.Instance.Admin.Prezime).ShowDialog();
            this.Show();
            kki.PrikaziSveFilmove(dgvFilmovi);
        }

        private void btnUnesiKategoriju_Click(object sender, EventArgs e)
        {
            kki.SacuvajKategoriju(txtUnesiKategoriju);
            kki.PrikaziSveKategorije(dgvKategorije);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiFilm(dgvFilmovi);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Film film = dgvFilmovi.CurrentRow.DataBoundItem as Film;
            this.Hide();
            new FrmIzmeniFilm(film, Sesija.Instance.Admin.Ime, Sesija.Instance.Admin.Prezime).ShowDialog();
            this.Show();
            kki.PrikaziSveFilmove(dgvFilmovi);
        }
    }
}
