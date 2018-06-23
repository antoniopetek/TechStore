using TechStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TechStoreTest
{
    [TestClass]
    public class PoslovnicaTest
    {
        [TestMethod]
        public void DohvatiPoslovnicuTest_PoslovnicaPostoji()
        {
            Poslovnica poslovnica = null;
            poslovnica = Poslovnica.DohvatiPoslovnicu(1);
            Assert.IsNotNull(poslovnica);
        }

        [TestMethod]
        public void DohvatiPoslovnicuTest_PoslovnicaNePostoji()
        {
            Poslovnica poslovnica = null;
            poslovnica = Poslovnica.DohvatiPoslovnicu(99);
            Assert.IsNull(poslovnica);
        }
    }
}
