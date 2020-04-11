using System.Collections;
using BlabberApp.Domain;
using BlabberApp.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class BlabSQLTest
    {
        private string userEmail = "foobar@example.com";
        private User newUser;
        private Blab newBlab;
        private BlabAdapter adapter;
        private string blabMessage = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
    
        [TestInitialize]
        public void Setup()
        {
            newUser = new User(userEmail);
            newBlab = new Blab(blabMessage, newUser);
            adapter = new BlabAdapter(new SqlBlab());
        }

        [TestCleanup]
        public void Teardown()
        {
            adapter.Delete(newBlab);
        }

        [TestMethod]
        public void TestAddGetById()
        {
            adapter.Add(newBlab);
            /*
            adapterHarness.Add(user);
            User actual = adapterHarness.GetById(user.Id);
            Assert.AreEqual(user.Id, actual.Id);
            */
            Blab actual = adapter.GetById(newBlab);
            Assert.AreEqual(newBlab.Id, actual.Id);
        }
    }
}