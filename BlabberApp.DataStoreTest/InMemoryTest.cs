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
        private InMemory<Blab> harness;
        public InMemoryTest()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>().UseInMemoryDatabase(databaseName: "addBlabs").Options;
            harness = new InMemory<Blab>(new ApplicationContext(options));
        }

        [TestMethod]
        public void TestAddAndGetByID()
        {
            Blab expected = new Blab();
            expected.UserID = "foobar@example.com";
            expected.Message = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            string sysID = expected.getSysId();
            harness.Add(expected);

            Blab actual =  harness.GetByUserID("foobar@example.com");
            
            Assert.AreEqual(expected, actual);
        }

    }
}
