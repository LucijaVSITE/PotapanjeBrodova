using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace UnitTests
{
    [TestClass]
    public class TestNapipač
    {
        [TestMethod]
        public void Napipač_ListaPoljaZaHorizontalniBrodDuljine3MoraSadržavati15Polja()
        {
            Mreža m = new Mreža(1, 7);
            const int duljinaBroda = 3;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());
        }

        [TestMethod]
        public void Napipač_ListaPoljaZaVertikalniBrodDuljine4MoraSadržavati16Polja()
        {
            Mreža m = new Mreža(5, 2);
            const int duljinaBroda = 4;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(16, n.DajKandidateZaVertikalniBrod().Count());
        }

        [TestMethod]
        public void Napipač_MoraSadržavatiPoljaUOdređenomBroju()
        { // 0->1 1->2 2->3   1233321
            Mreža m = new Mreža(1, 7);
            const int duljinaBroda = 3;
            Napipač n = new Napipač(m, duljinaBroda);
            

             
            Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());
        }
    }
}
