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
        public Topništvo(int redaka, int stupaca, int[] duljineBrodova)
        {
            mreža = new Mreža(redaka, stupaca);
            this.duljineBrodova =new List<int>(duljineBrodova);
            this.duljineBrodova.Sort((d1,d2)=> d2 - d1);
            PromjeniTaktikuUNapipavanje();

        }

        public Polje UputiPucanj()
        {
            return pucač.UputiPucanj();
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
            pucač = new Napipač(mreža, duljineBrodova[0]);
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
        IPucač pucač;
        Mreža mreža;
        List<int> duljineBrodova;
    }   
}
