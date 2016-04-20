using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum RezultatGađanja
    {
        Promašaj,
        Pogodak,
        Potonuće
    }

    public class Brod
    {
        public Brod(IEnumerable<Polje> polja)
        {
            this.Polja = polja;
        }

        public int Duljina
        {
            get { return Polja.Count(); }
        }

        public RezultatGađanja Gađaj(Polje p)
        {
            if (Polja.Contains(p))
            {
                pogođenaPolja.Add(p);
                if (pogođenaPolja.Count == Polja.Count())
                    return RezultatGađanja.Potonuće;
                return RezultatGađanja.Pogodak;
            }
            return RezultatGađanja.Promašaj;
        }

        public readonly IEnumerable<Polje> Polja;
        private HashSet<Polje> pogođenaPolja = new HashSet<Polje>();
    }
}
