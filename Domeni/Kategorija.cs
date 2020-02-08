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
    public class Kategorija:IDomenskiObjekat
    {
        int idKategorije;
        string naziv;

        [Browsable(false)]
        public int IdKategorije { get => idKategorije; set => idKategorije = value; }
        [DisplayName("Naziv kategorije")]
        public string Naziv { get => naziv; set => naziv = value; }

        [Browsable(false)]
        public string Tabela => "Kategorija";
        [Browsable(false)]
        public string VrednostZaJoin => "Kategorija k";
        [Browsable(false)]
        public string VrednostiZaInsert => $"'{Naziv}'";
        [Browsable(false)]
        public string VrednostiZaPretragu => "k.Naziv";
        [Browsable(false)]
        public string VrednostiZaSK => "Kategorija";
        [Browsable(false)]
        public string UslovIdentifikator => $"Id = '{IdKategorije}'";
        [Browsable(false)]
        public string NazivKolone => "Naziv";
        [Browsable(false)]
        public string VrednostZaUpdate => $"Naziv = '{Naziv}'";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> kategorije = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Kategorija k = new Kategorija
                {
                    IdKategorije = (int)reader["Id"],
                    Naziv = (reader["Naziv"]).ToString()
                };
                kategorije.Add(k);
            }
            return kategorije;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
