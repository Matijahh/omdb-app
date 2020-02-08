using Domeni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        private Socket klijentskiSoket;
        private NetworkStream tok;
        private BinaryFormatter formater = new BinaryFormatter();

        public Komunikacija()
        {

        }

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null)
                    instance = new Komunikacija();
                return instance;
            }
        }

        internal Admin PrijaviSe(string korisnickoIme, string lozinka)
        {
            Admin a = new Admin { KorIme = korisnickoIme, Lozinka = lozinka };
            Zahtev z = new Zahtev { Operacija = Operacija.Prijava, Objekat = a };
            formater.Serialize(tok, z);
            Odgovor odg = (Odgovor)formater.Deserialize(tok);
            if (odg.Signal == Signal.Ok)
            {
                return (Admin)odg.Objekat;
            }
            else
            {
                return null;
            }
        }

        internal Korisnik PrijaviKorisnika(string korIme, string loz)
        {
            Korisnik k = new Korisnik { KorIme = korIme, Lozinka = loz };
            Zahtev z = new Zahtev { Operacija = Operacija.Prijava, Objekat = k };
            formater.Serialize(tok, z);
            Odgovor odg = (Odgovor)formater.Deserialize(tok);
            if (odg.Signal == Signal.Ok)
            {
                return (Korisnik)odg.Objekat;
            }
            else
            {
                return null;
            }
        }

        internal List<Film> PrikaziFilmove(string deoNaziva)
        {
            Zahtev z = new Zahtev { Operacija = Operacija.PrikaziFilmove, Objekat = deoNaziva };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (List<Film>)odg.Objekat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal List<Film> PrikaziSveFilmove()
        {
            Zahtev z = new Zahtev { Operacija = Operacija.PrikaziSveFilmove };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (List<Film>)odg.Objekat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal List<Kategorija> PrikaziSveKategorije()
        {
            Zahtev z = new Zahtev { Operacija = Operacija.PrikaziSveKategorije };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (List<Kategorija>)odg.Objekat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal Film SacuvajFilm(Film f)
        {
            Zahtev z = new Zahtev { Operacija = Operacija.SacuvajFilm, Objekat = f };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (Film)odg.Objekat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal Ocena SacuvajOcenu(Ocena o)
        {
            Zahtev z = new Zahtev { Operacija = Operacija.SacuvajOcenu, Objekat = o };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (Ocena)odg.Objekat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal Kategorija SacuvajKategoriju(Kategorija f)
        {
            Zahtev z = new Zahtev { Operacija = Operacija.SacuvajKategoriju, Objekat = f };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (Kategorija)odg.Objekat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal bool ObrisiFilm(Film f)
        {
            Zahtev z = new Zahtev { Operacija = Operacija.ObrisiFilm, Objekat = f };
            try
            {
                formater.Serialize(tok, z);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                if (odg.Signal == Signal.Ok)
                {
                    return (bool)odg.Objekat;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool PoveziSe()
        {
            try
            {
                klijentskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                klijentskiSoket.Connect("localhost", 9090);
                tok = new NetworkStream(klijentskiSoket);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }
    }
}
