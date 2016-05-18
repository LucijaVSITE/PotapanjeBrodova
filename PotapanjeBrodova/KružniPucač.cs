using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{

   

    public class KružniPucač : IPucač
    {
        public KružniPucač(Polje prvoPogođeno, Mreža mreža)
        {
            this.mreža = mreža;
            this.prvoPogođeno = prvoPogođeno;
        }

        // tražimo za sve smjerove broj slobodnih polja u tom smijeru
        // listu od 4 liste polja
        // sortiraj te listem, tako da je najdulja prva
        // između najduljih biram jednu slučanjim odabirom
        // iz nje vadim prvo polje
        public Polje UputiPucanj()
        {
            int redak = prvoPogođeno.Redak;
            int stupac = prvoPogođeno.Stupac;
            List<IEnumerable<Polje>> kandidati =new List<IEnumerable<Polje>>();

            foreach (Smijer smjer in Enum.GetValues(typeof(Smijer)))
            {
                kandidati.Add(mreža.DajPoljaUZadanomSmjeru(redak, stupac, smjer));
            }
            kandidati.Sort((lista1, lista2) => lista2.Count() - lista1.Count());
            var grupe=kandidati.GroupBy(lista => lista.Count());
            var najdulji = grupe.First();
            if (najdulji.Count() == 1)
                return najdulji.First().First();
            int indeks = slučajni.Next(najdulji.Count());
             return najdulji.ElementAt(indeks).First();
        }

        public void EvidentirajRezultat(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        Polje prvoPogođeno;
        Mreža mreža;
        Random slučajni = new Random();

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }   
}
