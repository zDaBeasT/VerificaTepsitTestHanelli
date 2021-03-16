using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalestraLibrary;

namespace PalestraTest
{
    [TestClass]
    public class Palestra
    {
        [TestMethod]
        public void Test1mese()
        {
            int a = 1;
            string ValoreAspettato = "La tariffa più conveniente è quella da un mese";
            string ValoreRitorno = Gestione.RichiestaUtente(a);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);
        }

        [TestMethod]
        public void Test3mesi()
        {
            int a = 3;
            string ValoreAspettato = "La tariffa più conveniente è quella da tre mesi";
            string ValoreRitorno = Gestione.RichiestaUtente(a);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);
        }
        
        [TestMethod]
        public void Test12mesi()
        {
            int a = 12;
            string ValoreAspettato = "La tariffa più conveniente è quella da dodici mesi";
            string ValoreRitorno = Gestione.RichiestaUtente(a);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);
        }
    }
}
