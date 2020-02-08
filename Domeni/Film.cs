using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    [Serializable]
    public class Film:IDomenskiObjekat
    {
        int idFilma;
        string naziv;
        int godina;
        string menjanOd;

        [DisplayName("ID")]
        public int IdFilma { get => idFilma; set => idFilma = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Godina { get => godina; set => godina = value; }
        [DisplayName("Poslednji put menjao")]
        public string MenjanOd { get => menjanOd; set => menjanOd = value; }

        [Browsable(false)]
        public string Tabela => "Film";
        [Browsable(false)]
        public string VrednostZaJoin => "Film f";
        [Browsable(false)]
        public string VrednostiZaInsert => $"'{Naziv}', {Godina}, '{MenjanOd}'";
        [Browsable(false)]
        public string VrednostiZaPretragu => "f.Naziv";
        [Browsable(false)]
        public string VrednostiZaSK => "Film";
        [Browsable(false)]
        public string UslovIdentifikator => $"Id = {IdFilma}";
        [Browsable(false)]
        public string NazivKolone => "Naziv";
        [Browsable(false)]
        public string VrednostZaUpdate => $"Naziv = '{Naziv}', Godina = {Godina}, MenjanOd = '{MenjanOd}'";
        [Browsable(false)]
        public string Join => "";

        public override string ToString()
        {
            return Naziv;
        }

        [Browsable(false)]
        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> filmovi = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Film f = new Film
                {
                    IdFilma = (int)reader["Id"],
                    Naziv = (reader["Naziv"]).ToString(),
                    Godina = (int)reader["Godina"],
                    MenjanOd = (reader["MenjanOd"]).ToString()
                };
                filmovi.Add(f);
            }
            return filmovi;
        }
    }
}
