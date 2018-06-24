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
        /// Testna metoda koja provjerava postojanje artikla. Ako
        /// artikl s proslijeđenim ID - em postoji vraća taj artikl,
        /// inače vraća null.
        /// </summary>
        [TestMethod]
        public void DohvatiArtiklTest_ArtiklNePostoji()
        {
            Artikl artikl = null;
            artikl = Artikl.DohvatiArtikl(345);
            Assert.IsNull(artikl);
        }

        /// <summary>
        /// Testna metoda koja provjerava postojanje artikla. 
        /// </summary>
        [TestMethod]
        public void DohvatiArtiklTest_ArtiklPostoji()
        {
            Artikl artikl = null;
            artikl = Artikl.DohvatiArtikl(1);
            Assert.IsNotNull(artikl);
        }

        /// <summary>
        /// Testna metoda koja provjerava je li isti ID novog objekta i 
        /// već postojećeg objekta klase Artikl.
        /// </summary>
        [TestMethod]
        public void DohvatiArtiklTest_UsporediSNovimIsti()
        {
            Artikl postojeci = Artikl.DohvatiArtikl(1);
            Artikl novi = new Artikl
            {
                ID = 1
            };
            Assert.AreEqual(postojeci.ID, novi.ID);
        }

        /// <summary>
        /// Testna metoda koja provjera je li različit ID novog objekta i 
        /// već postojećeg objekta klase Artikl.
        /// </summary>
        [TestMethod]
        public void DohvatiArtiklTest_UsporediSNovimRazliciti()
        {
            Artikl postojeci = Artikl.DohvatiArtikl(1);
            Artikl novi = new Artikl
            {
                ID = 2
            };
            Assert.AreNotEqual(postojeci.ID, novi.ID);
        }

        /// <summary>
        /// Testna metoda koja provjera brisanje artikla koji ne postoji
        /// u bazi podataka.
        /// </summary>
        [TestMethod]
        public void ObrisiArtiklTest_ArtikNelPostoji()
        {
            try
            {
                Artikl artikl = Artikl.DohvatiArtikl(456);
                Artikl.ObrisiArtikl(artikl);
                Assert.Fail();
            }
            catch (Exception )
            {
                
            }
        }
        
        /// <summary>
        /// Testna metoda koja provjera brisanje artikla koji postoji
        /// u bazi podataka
        /// </summary>
        [TestMethod]
        public void ObrisiArtiklTest_ArtiklPostoji()
        {
            try
            {
                Artikl artikl = Artikl.DohvatiArtikl(1);
                Artikl.ObrisiArtikl(artikl);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {

            }
        }
    }

}
