using BlabberApp.Domain;
using BlabberApp.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class UserSQLTest
    {
        private User user;
        private UserAdapter adapterHarness;
        private readonly string userEmail = "foobar@example.com";

        [TestInitialize]
        public void Setup()
        {
            user = new User(userEmail);
            adapterHarness = new UserAdapter(new SqlUser());
        }
        
        [TestMethod]
        public void TestNewAndGetUser()
        {
            adapterHarness.Add(user);
            User actual = adapterHarness.GetById(user.Id);
            Assert.AreEqual(user.Id, actual.Id);
        }
    }
}