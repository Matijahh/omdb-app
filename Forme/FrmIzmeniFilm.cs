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
    public partial class FrmIzmeniFilm : Form
    {
        private string ime;
        private string prezime;
        private Film film;

        KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();

        public FrmIzmeniFilm()
        {
            InitializeComponent();
        }

        public FrmIzmeniFilm(string ime, string prezime)
        {
            InitializeComponent();
        }

        public FrmIzmeniFilm(Film film, string ime, string prezime)
        {

            InitializeComponent();
            this.film = film;
            this.ime = ime;
            this.prezime = prezime;
            lblKorisnikIme.Text = ime + " " + prezime;
            label1.Text = film.Naziv;
            label2.Text = film.IdFilma.ToString();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            kki.IzmeniFilm(film, txtNoviNaziv, txtGodina, lblKorisnikIme);
        }
    }
}
