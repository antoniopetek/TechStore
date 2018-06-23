using TechStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TechStoreTest
{
    /// <summary>
    /// Testna klasa PoslovnicaTest.
    /// </summary>
    [TestClass]
    public class PoslovnicaTest
    {
        /// <summary>
        /// Testna metoda koja provjerava ako poslovnica postoji. Ako poslovnica s proslijeđenim
        /// podacima postoji vraća zaposlenika, inače vraća null.
        /// </summary>

        [TestMethod]
        public void DohvatiPoslovnicuTest_PoslovnicaPostoji()
        {
            Poslovnica poslovnica = null;
            poslovnica = Poslovnica.DohvatiPoslovnicu(1);
            Assert.IsNotNull(poslovnica);
        }

        /// <summary>
        /// Testna metoda koja provjerava ako poslovnica postoji. Ako poslovnica s proslijeđenim
        /// podacima postoji vraća zaposlenika, inače vraća null.
        /// </summary>
        [TestMethod]
        public void DohvatiPoslovnicuTest_PoslovnicaNePostoji()
        {
            Poslovnica poslovnica = null;
            poslovnica = Poslovnica.DohvatiPoslovnicu(99);
            Assert.IsNull(poslovnica);
        }
    }
}
