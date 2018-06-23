using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechStore;

namespace TechStoreTest
{
    /// <summary>
    /// Testna klasa ZaposlenikTest.
    /// </summary>
    [TestClass]
    public class ZaposlenikTest
    {
        /// <summary>
        /// Testna metoda koja provjerava ako zaposlenik postoji. Ako zaposlenik s proslijeđenim
        /// podacima postoji vraća zaposlenika, inače vraća null.
        /// </summary>
        [TestMethod]
        public void DohvatiZaposlenikaTest_ZaposlenikPostoji()
        {
            Zaposlenik zaposlenik = null;
            zaposlenik = Zaposlenik.DohvatiZaposlenika("apetek", "password");
            Assert.IsNotNull(zaposlenik);
        }

        /// <summary>
        /// Testna metoda koja provjerava ako zaposlenik postoji. Ako zaposlenik s proslijeđenim
        /// podacima postoji vraća zaposlenika, inače vraća null.
        /// </summary>
        [TestMethod]
        public void DohvatiZaposlenikaTest_ZaposlenikNePostoji()
        {
            Zaposlenik zaposlenik = null;
            zaposlenik = Zaposlenik.DohvatiZaposlenika("marulic", "marko");
            Assert.IsNull(zaposlenik);
        }
    }
}
