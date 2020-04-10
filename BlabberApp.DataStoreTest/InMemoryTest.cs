using System.Collections;
using System.Collections.Generic;
using BlabberApp.Domain;
using BlabberApp.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;

namespace BlabberApp.DataStoreTest

{
    [TestClass]
    public class InMemoryTest
    {

        [TestMethod]
        public void TestAddAndGetByID()
        {
            Assert.AreEqual(true, true);
        }

    }
}
