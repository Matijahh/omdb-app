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
    public partial class FrmGlavnaFormaKorisnik : Form
    {
        KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();

        public FrmGlavnaFormaKorisnik()
        {
            InitializeComponent();
            lblKorisnik.Text += " " + Sesija.Instance.Korisnik.Ime + " " + Sesija.Instance.Korisnik.Prezime;
            kki.PrikaziSveFilmove(dgvFilmovi);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kki.PrikaziFilmove(dgvFilmovi, txtPretrazi);
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnesiOcenu_Click(object sender, EventArgs e)
        {
            Film f = dgvFilmovi.CurrentRow.DataBoundItem as Film;
            this.Hide();
            new FrmOcena(f, Sesija.Instance.Korisnik).ShowDialog();
            this.Show();
            kki.PrikaziSveFilmove(dgvFilmovi);
        }
    }
}
