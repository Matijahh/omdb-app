using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domeni;

namespace SistemskeOperacije
{
    public class IzmeniFilmSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
        {
            if (broker.Izmeni(objekat) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }
        }

        protected override void Validacija(IDomenskiObjekat objekat)
        {
            if (!(objekat is Film))
            {
                throw new ArgumentException();
            }
        }
    }
}
