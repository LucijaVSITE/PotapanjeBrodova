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

        public Polje UputiPucanj()
        {
            throw new NotImplementedException();
        }

        private Polje prvoPogođeno;
        private Mreža mreža;
    }   
}
