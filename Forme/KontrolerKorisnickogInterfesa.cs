using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public class KontrolerKorisnickogInterfejsa
    {
        public KontrolerKorisnickogInterfejsa()
        {

        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Lozinka mora imati najmanje 6 karaktera");
                return false;
            }
            if (password.All(Char.IsLetter))
            {
                MessageBox.Show("Lozinka mora sadržati cifru");
                return false;
            }
            if (password.All(Char.IsLower))
            {
                MessageBox.Show("Lozinka mora sadržati veliko slovo");
                return false;
            }
            return true;
        }

        // FrmPrijaviSe

        internal void Prijavi(TextBox txtUser, TextBox txtPass, CheckBox cbAdmin)
        {
            bool jesteAdmin = cbAdmin.Checked;

            if (Komunikacija.Instance.PoveziSe())
            {
                string korIme = txtUser.Text;
                string loz = txtPass.Text;

                if (jesteAdmin)
                {
                    Admin a = Komunikacija.Instance.PrijaviSe(korIme, loz);
                    if (a != null)
                    {
                        MessageBox.Show("Uspešno ste se prijavili");
                        Sesija.Instance.Admin = a;
                        FrmGlavnaFormaAdmin forma = new FrmGlavnaFormaAdmin();
                        forma.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešno uneti parametri za administratora");
                    }
                }
                else
                {
                    Korisnik k = Komunikacija.Instance.PrijaviKorisnika(korIme, loz);
                    if (k != null)
                    {
                        MessageBox.Show("Uspešno ste se prijavili");
                        Sesija.Instance.Korisnik = k;
                        FrmGlavnaFormaKorisnik forma = new FrmGlavnaFormaKorisnik();
                        forma.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije moguće povezati se sa serverom");
            }
        }

        // FrmGlavnaFormaAdmin/Korisnik

        internal void PrikaziFilmove(DataGridView dgvFilmovi, TextBox txtNaziv)
        {
            string deoNaziva = txtNaziv.Text;
            List<Film> listaFilmova = Komunikacija.Instance.PrikaziFilmove(deoNaziva);
            if (listaFilmova.Count != 0)
            {
                dgvFilmovi.DataSource = listaFilmova;
            }
            else
            {
                MessageBox.Show("Nije pronađen nijedan film sa ovim nazivom");
                PrikaziSveFilmove(dgvFilmovi);
            }
        }

        BindingList<Film> listaFilmovaBinding = new BindingList<Film>();

        internal void PrikaziSveFilmove(DataGridView dgvFilmovi)
        {
            List<Film> listaFilmova = Komunikacija.Instance.PrikaziSveFilmove();
            if (listaFilmova != null)
            {
                listaFilmovaBinding = new BindingList<Film>(listaFilmova);
                
                dgvFilmovi.DataSource = listaFilmova;
            }
            else MessageBox.Show("Nije pronađen nijedan film");
        }

        BindingList<Kategorija> listaKategorijaBinding = new BindingList<Kategorija>();

        internal void PrikaziSveKategorije(DataGridView dgvKategorije)
        {
            List<Kategorija> listaKategorija = Komunikacija.Instance.PrikaziSveKategorije();
            if (listaKategorija != null)
            {
                listaKategorijaBinding = new BindingList<Kategorija>(listaKategorija);

                dgvKategorije.DataSource = listaKategorija;
            }
            else MessageBox.Show("Nije pronađena nijedna kategorija");
        }

        internal void PrikaziSveKategorijeCmb(ComboBox comboKategorija)
        {
            List<Kategorija> listaKategorija = Komunikacija.Instance.PrikaziSveKategorije();
            if (listaKategorija != null)
            {
                listaKategorijaBinding = new BindingList<Kategorija>(listaKategorija);

                comboKategorija.DataSource = listaKategorija;
            }
            else MessageBox.Show("Nije pronađena nijedna kategorija");
        }

        internal void SacuvajKategoriju(TextBox txtNaziv)
        {
            if (!ProveraUnosaKategorije(txtNaziv))
            {
                MessageBox.Show("Doslo je do greške, pokušajte ponovo");
                return;
            };

            Kategorija f = new Kategorija();
            f.Naziv = txtNaziv.Text;

            Kategorija sacuvanaKategorija = Komunikacija.Instance.SacuvajKategoriju(f);
            if (sacuvanaKategorija != null)
            {
                MessageBox.Show("Kategorija je uspešno sačuvana");
                SrediPoljeKategorija(txtNaziv);
            }
            else
            {
                MessageBox.Show("Kategorija nije sačuvana");
                SrediPoljeKategorija(txtNaziv);
            }
        }

        bool ProveraUnosaKategorije(TextBox txtNaziv)
        {
            bool ispravno = true;
            if (string.IsNullOrEmpty(txtNaziv.Text) || txtNaziv.Text == "")
            {
                ispravno = false;
            }
            return ispravno;
        }

        public void SrediPoljeKategorija(TextBox txtNaziv)
        {
            txtNaziv.Text = "";
        }

        internal void ObrisiFilm(DataGridView dgvFilmovi)
        {
            int idFilmaZaBrisanje = -1;
            if (dgvFilmovi.SelectedRows.Count > 0)
            {
                idFilmaZaBrisanje = Int32.Parse(dgvFilmovi.SelectedCells[0].Value.ToString());
            }

            bool obrisan = false;
            if (idFilmaZaBrisanje != -1)
            {
                Film f = new Film { IdFilma = idFilmaZaBrisanje };
                obrisan = Komunikacija.Instance.ObrisiFilm(f);
                if (obrisan == true)
                {
                    MessageBox.Show("Uspešno je obrisan film");
                    int idFilma = (int)dgvFilmovi.SelectedRows[0].Cells[0].Value;
                    listaFilmovaBinding.Remove(new Film { IdFilma = idFilma });
                    PrikaziSveFilmove(dgvFilmovi);
                }
                else MessageBox.Show("Nije moguće obrisati film");
            }
            else
                MessageBox.Show("Morate odabrati film za brisanje");
        }

        // FrmDodajFilm

        internal void SacuvajFilm(TextBox txtNaziv, TextBox txtGodina, Label lblAdmin)
        {
            if (!ProveraUnosaFilma(txtNaziv, txtGodina, lblAdmin))
            {
                MessageBox.Show("Došlo je do greške, pokušajte ponovo");
                return;
            };

            Film f = new Film();
            f.Naziv = txtNaziv.Text;
            f.Godina = Convert.ToInt32(txtGodina.Text);
            f.MenjanOd = lblAdmin.Text;

            Film sacuvanFilm = Komunikacija.Instance.SacuvajFilm(f);
            if (sacuvanFilm != null)
            {
                MessageBox.Show("Film je uspešno sačuvan");
                SrediFormuDodaj(txtNaziv, txtGodina);
            }
            else
            {
                MessageBox.Show("Film nije sačuvan");
                SrediFormuDodaj(txtNaziv, txtGodina);
            }
        }

        bool ProveraUnosaFilma(TextBox txtNaziv, TextBox txtGodina, Label lblAdmin)
        {
            bool ispravno = true;
            if (string.IsNullOrEmpty(txtNaziv.Text) || txtNaziv.Text == "")
            {
                ispravno = false;
            }
            if (!int.TryParse(txtGodina.Text, out int _))
            {
                ispravno = false;
            }
            if (string.IsNullOrEmpty(lblAdmin.Text) || lblAdmin.Text == "")
            {
                ispravno = false;
            }
            return ispravno;
        }

        public void SrediFormuDodaj(TextBox txtNaziv, TextBox txtGodina)
        {
            txtNaziv.Text = "";
            txtGodina.Text = "";
        }

        // FrmIzmeniFilm

        internal void IzmeniFilm(Film f, TextBox txtNaziv, TextBox txtGodina, Label lblAdmin)
        {
            string noviNaziv = null;
            int novaGodina = -1;
            string menjanOd = null;

            if (!string.IsNullOrEmpty(txtNaziv.Text) && txtNaziv.Text != "")
            {
                noviNaziv = txtNaziv.Text;
            }
            else
            {
                MessageBox.Show("Niste uneli novi naziv");
                return;
            }

            if (!string.IsNullOrEmpty(lblAdmin.Text) && lblAdmin.Text != "")
            {
                menjanOd = lblAdmin.Text;
            }
            else
            {
                MessageBox.Show("Došlo je do greške");
                return;
            }

            if (!string.IsNullOrEmpty(txtGodina.Text) && txtGodina.Text != "")
            {
                bool cenaBool = Int32.TryParse(txtGodina.Text, out int nova);
                if (cenaBool) novaGodina = nova;
                else
                {
                    MessageBox.Show("Godina nije u odgovarajućem formatu");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Godina nije u odgovarajućem formatu");
                return;
            }


            int id = f.IdFilma;
            Film fm = new Film { IdFilma = id, Naziv = noviNaziv, Godina = novaGodina, MenjanOd = menjanOd };

            bool uspesno = Kontroler.Kontroler.Instance.IzmeniFilm(fm);
            if (uspesno)
            {
                MessageBox.Show("Uspešno ste izmenili film");
                SrediPoljaIzmeni(txtNaziv, txtGodina);
            }
            else
            {
                MessageBox.Show("Nije moguće izmeniti izabrani film");
            }
        }

        public void SrediPoljaIzmeni(TextBox txtNaziv, TextBox txtGodina)
        {
            txtNaziv.Text = "";
            txtGodina.Text = "";
        }

        // FrmOcena

        internal void SacuvajOcenu(TextBox txtOcena, ComboBox cmbKategorija, Korisnik k, Film f)
        {
            if (!ProveraUnosaOcene(txtOcena, cmbKategorija))
            {
                MessageBox.Show("Došlo je do greške, pokušajte ponovo");
                return;
            };

            Ocena o = new Ocena();
            o.Film = f;
            o.Korisnik = k;
            o.Kategorija = cmbKategorija.SelectedItem as Kategorija;
            o.OcenaFilma = Convert.ToInt32(txtOcena.Text);

            if(o.OcenaFilma <1 || o.OcenaFilma > 10)
            {
                MessageBox.Show("Ocena mora biti u intervalu 1-10");
                return;
            }

            Ocena sacuvanaOcena = Komunikacija.Instance.SacuvajOcenu(o);
            if (sacuvanaOcena != null)
            {
                MessageBox.Show("Ocena je uspešno sačuvana");
                SrediFrmOcena(txtOcena);
            }
            else
            {
                MessageBox.Show("Ocena nije sačuvana");
                SrediFrmOcena(txtOcena);
            }
        }

        bool ProveraUnosaOcene(TextBox txtOcena, ComboBox cmbKategorija)
        {
            bool ispravno = true;
            if (!int.TryParse(txtOcena.Text, out int _))
            {
                ispravno = false;
            }
            if (cmbKategorija.DataSource == null)
            {
                ispravno = false;
            }
            return ispravno;
        }

        public void SrediFrmOcena(TextBox txtOcena)
        {
            txtOcena.Text = "";
        }
    }
}
