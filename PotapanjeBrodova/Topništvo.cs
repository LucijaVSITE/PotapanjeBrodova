using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja{
        Napipavanje,
        Okruživanje,
        SustavnoUništavanje
    }

    public class Topništvo
    {
        public Topništvo()
        {
            PromjeniTaktikuUNapipavanje();
        }

        public Polje UputiPucanj()
        {

            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            //DZ da testovi prođu
            if (rezultat == RezultatGađanja.Potonuće)
                PromjeniTaktikuUNapipavanje();
            else 
            if (rezultat == RezultatGađanja.Pogodak)
            {
                if (TrenutnaTaktika == TaktikaGađanja.Napipavanje)
                    PromjeniTaktikuUOkruživanje();
                else if (TrenutnaTaktika == TaktikaGađanja.Okruživanje)
                    PromjeniTaktikuUSustavnoUništavanje();
            }
        }

        private void PromjeniTaktikuUNapipavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;
        }

        private void PromjeniTaktikuUOkruživanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Okruživanje;
        }

        private void PromjeniTaktikuUSustavnoUništavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.SustavnoUništavanje;
        }

        public TaktikaGađanja TrenutnaTaktika
        {
            get;
            private set;
        }

    }
}
