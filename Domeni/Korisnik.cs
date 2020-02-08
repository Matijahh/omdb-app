using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    [Serializable]
    public class Korisnik : IDomenskiObjekat
    {
        public int IDKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorIme { get; set; }
        public string Lozinka { get; set; }

        public string Tabela => "Korisnik";

        public string VrednostiZaInsert => $"'{Ime}', '{Prezime}', '{KorIme}', '{Lozinka}'";

        public string VrednostiZaPretragu => $"Id = {IDKorisnika}";

        public string VrednostiZaSK => throw new NotImplementedException();

        public string UslovIdentifikator => $"{IDKorisnika}";

        public string NazivKolone => throw new NotImplementedException();

        public string VrednostZaUpdate => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string VrednostZaJoin => throw new NotImplementedException();

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> korisnici = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Korisnik k = new Korisnik
                {
                    IDKorisnika = (int)reader["Id"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    KorIme = (string)reader["Username"],
                    Lozinka = (string)reader["Password"]
                };
                korisnici.Add(k);
            }
            return korisnici;
        }
    }

}