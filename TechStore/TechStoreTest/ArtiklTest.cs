using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechStoreTest
{
    /// <summary>
    /// Testna klasa ArtiklTest.
    /// </summary>
    [TestClass]
    public class ArtiklTest
    {
        /// <summary>
        /// Testna metoda koja provjerava postojanje artikla. Ako artikl s proslijeđenim
        /// ID - em postoji vraća taj artikl, inače vraća null.
        /// </summary>
        [TestMethod]
        public void DohvatiArtiklTest_ArtiklNePostoji()
        {
            Artikl artikl = null;
            artikl = Artikl.DohvatiArtikl(345);
            Assert.IsNull(artikl);
        }

        /// <summary>
        /// Testna metoda koja provjerava postojanje artikla. Ako artikl s proslijeđenim
        /// ID - em postoji vraća taj artikl, inače vraća null.
        /// </summary>
        [TestMethod]
        public void DohvatiArtiklTest_ArtiklPostoji()
        {
            Artikl artikl = null;
            artikl = Artikl.DohvatiArtikl(1);
            Assert.IsNotNull(artikl);
        }
       
    }

}
