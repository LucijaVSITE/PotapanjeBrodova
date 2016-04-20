using System.Collections.Generic;

namespace PotapanjeBrodova
{
    public class Flota
    {
        public void DodajBrod(Brod b)
        {
            brodovi.Add(b);
        }

        public IEnumerable<Brod> Brodovi
        {
            get { return brodovi; }
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }

        public RezultatGađanja Gađaj(Polje polje)
        {
            foreach (Brod b in brodovi)
            {
                b.Gađaj(polje);
                var rezultat = b.Gađaj(polje);
                if (b.Gađaj(polje) != RezultatGađanja.Promašaj) {
                    return rezultat;
                }
            }
            return RezultatGađanja.Promašaj;
        }

        List<Brod> brodovi = new List<Brod>();
    }
}
