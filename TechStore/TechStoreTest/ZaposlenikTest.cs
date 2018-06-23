using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechStore;

namespace TechStoreTest
{
    [TestClass]
    public class ZaposlenikTest
    {
        [TestMethod]
        public void DohvatiZaposlenikaTest_ZaposlenikPostoji()
        {
            Zaposlenik zaposlenik = null;
            zaposlenik = Zaposlenik.DohvatiZaposlenika("apetek", "password");
            Assert.IsNotNull(zaposlenik);
        }

        [TestMethod]
        public void DohvatiZaposlenikaTest_ZaposlenikNePostoji()
        {
            Zaposlenik zaposlenik = null;
            zaposlenik = Zaposlenik.DohvatiZaposlenika("marulic", "marko");
            Assert.IsNull(zaposlenik);
        }
    }
}
