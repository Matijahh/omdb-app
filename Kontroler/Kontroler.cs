using BrokerBazePodataka;
using Domeni;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Kontroler
    {
        private Broker broker = new Broker();
        private static Kontroler _instance;

        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kontroler();
                }
                return _instance;
            }
        }

        private Kontroler()
        {
        }

        // Genericke metode

        public Korisnik PrijaviKorisnika(string korIme, string loz)
        {
            Korisnik kor = new Korisnik { KorIme = korIme, Lozinka = loz };

            OpstaSistemskaOperacija sistemskaOperacija = new PrijaviKorisnikaSO();
            sistemskaOperacija.Izvrsi(new Korisnik());
            List<Korisnik> korisnici = ((PrijaviKorisnikaSO)sistemskaOperacija).Korisnici;

            foreach (Korisnik k in korisnici)
            {
                if (k.KorIme.Trim() == korIme && k.Lozinka.Trim() == loz)
                    return k;
            }
            return null;
        }

        public Admin PrijaviAdmina(string korIme, string loz)
        {
            Admin kor = new Admin { KorIme = korIme, Lozinka = loz };

            OpstaSistemskaOperacija sistemskaOperacija = new PrijavaAdministratoraSO();
            sistemskaOperacija.Izvrsi(new Admin());
            List<Admin> korisnici = ((PrijavaAdministratoraSO)sistemskaOperacija).Korisnici;

            foreach (Admin k in korisnici)
            {
                if (k.KorIme.Trim() == korIme && k.Lozinka.Trim() == loz)
                    return k;
            }
            return null;
        }

        public List<Film> VratiFilmove(string deoNaziva)
        {
            OpstaSistemskaOperacija sistemskaOperacija = new VratiFilmoveUzUslovSO();
            ((VratiFilmoveUzUslovSO)sistemskaOperacija).Uslov = deoNaziva;
            sistemskaOperacija.Izvrsi(new Film());
            return ((VratiFilmoveUzUslovSO)sistemskaOperacija).Filmovi;
        }

        public List<Film> VratiSveFilmove()
        {
            OpstaSistemskaOperacija sistemskaOperacija = new VratiSveFilmoveSO();
            sistemskaOperacija.Izvrsi(new Film());
            return ((VratiSveFilmoveSO)sistemskaOperacija).Filmovi;
        }

        public List<Kategorija> VratiSveKategorije()
        {
            OpstaSistemskaOperacija sistemskaOperacija = new VratiSveKategorijeSO();
            sistemskaOperacija.Izvrsi(new Kategorija());
            return ((VratiSveKategorijeSO)sistemskaOperacija).Kategorije;
        }

        public Film SacuvajFilm(Film f)
        {
            OpstaSistemskaOperacija sistemskaOperacija = new SacuvajFilmSO();
            sistemskaOperacija.Izvrsi(f);
            return ((SacuvajFilmSO)sistemskaOperacija).Film;
        }

        public Ocena SacuvajOcenu(Ocena o)
        {
            OpstaSistemskaOperacija sistemskaOperacija = new SacuvajOcenuSO();
            sistemskaOperacija.Izvrsi(o);
            return ((SacuvajOcenuSO)sistemskaOperacija).Ocena;
        }

        public Kategorija SacuvajKategoriju(Kategorija f)
        {
            OpstaSistemskaOperacija sistemskaOperacija = new SacuvajKategorijuSO();
            sistemskaOperacija.Izvrsi(f);
            return ((SacuvajKategorijuSO)sistemskaOperacija).Kategorija;
        }

        public bool ObrisiFilm(Film f)
        {
            OpstaSistemskaOperacija sistemskaOperacija = new ObrisiFilmSO();
            sistemskaOperacija.Izvrsi(f);
            return ((ObrisiFilmSO)sistemskaOperacija).Uspelo;
        }

        public bool IzmeniFilm(Film f)
        {
            OpstaSistemskaOperacija sistemskaOperacija = new IzmeniFilmSO();
            sistemskaOperacija.Izvrsi(f);
            return ((IzmeniFilmSO)sistemskaOperacija).Uspelo;
        }
    }
}