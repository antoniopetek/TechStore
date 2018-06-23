using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechStoreTest
{
    [TestClass]
    public class ArtiklTest
    {

        [TestMethod]
        public void DohvatiArtiklTest_ArtiklNePostoji()
        {
            Artikl artikl = null;
            artikl = Artikl.DohvatiArtikl(345);
            Assert.IsNull(artikl);
        }

        [TestMethod]
        public void DohvatiArtiklTest_ArtiklPostoji()
        {
            Artikl artikl = null;
            artikl = Artikl.DohvatiArtikl(1);
            Assert.IsNotNull(artikl);
        }
    }

}
