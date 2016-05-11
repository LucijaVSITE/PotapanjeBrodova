using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            switch (rezultat)
            {
                case RezultatGađanja.Potonuće:
                    PromjeniTaktikuUNapipavanje();
                    break;
                case RezultatGađanja.Pogodak:
                    switch (TrenutnaTaktika)
                    {
                        case TaktikaGađanja.Napipavanje:
                            PromjeniTaktikuUOkruživanje();
                            break;
                        case TaktikaGađanja.Okruživanje:
                            PromjeniTaktikuUSustavnoUništavanje();
                            break;
                        case TaktikaGađanja.SustavnoUništavanje:
                            break;
                        default:
                            Debug.Assert(false,string.Format("Nepodržana taktika {0}", TrenutnaTaktika.ToString()));
                            break;
                    }
                    break;
                case RezultatGađanja.Promašaj:
                    break;
                default:
                    Debug.Assert(false, string.Format("Nepodržani rezltat gađanja {0}", rezultat.ToString()));
                    break;
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
