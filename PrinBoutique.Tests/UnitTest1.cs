using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using PrinBoutique;
using GestionBD.MySQL;

namespace PrinBoutique.Tests
{
    [TestClass]
    public class GestionClientsTests
    {
        [TestMethod]
        public void TestGetNbTuplesByClients()
        {
            // Act
            int nbClients = GestionClients.getNbTuplesByClients();

            // Assert
            Assert.IsTrue(nbClients >= 0, "Le nombre de clients doit être positif ou nul.");
        }
    }
}
