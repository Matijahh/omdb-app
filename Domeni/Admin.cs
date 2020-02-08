using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    [Serializable]
    public class Admin : IDomenskiObjekat
    {
        public int IDAdmina { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorIme { get; set; }
        public string Lozinka { get; set; }

        public string Tabela => "Administrator";

        public string VrednostiZaInsert => $"'{Ime}', '{Prezime}', '{KorIme}', '{Lozinka}'";

        public string VrednostiZaPretragu => $"Id = {IDAdmina}";

        public string VrednostiZaSK => throw new NotImplementedException();

        public string UslovIdentifikator => $"{IDAdmina}";

        public string NazivKolone => throw new NotImplementedException();

        public string VrednostZaUpdate => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string VrednostZaJoin => throw new NotImplementedException();

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> korisnici = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Admin a = new Admin
                {
                    IDAdmina = (int)reader["Id"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    KorIme = (string)reader["Username"],
                    Lozinka = (string)reader["Password"]
                };
                korisnici.Add(a);
            }
            return korisnici;
        }
    }
}
