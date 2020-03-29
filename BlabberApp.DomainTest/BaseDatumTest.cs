using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BaseDatumTest
    {
        private BaseDatum _harness;
        public BaseDatumTest()
        {
            _harness = new BaseDatum();
        }
        [TestMethod]
        public void TestGetSysId()
        {
            string expected = _harness.getSysId();
            string actual = _harness.getSysId();
            Assert.AreEqual(actual.ToString(), expected.ToString());
            Assert.AreEqual(true, _harness.getSysId() is string);
        }

        [TestMethod]
        public void TestCreatedDttm()
        {
            BaseDatum Expected = new BaseDatum();
            BaseDatum Actual = new BaseDatum();
            Assert.AreEqual(Expected.CreatedDTTM.ToString(), Actual.CreatedDTTM.ToString());
        }

        [TestMethod]
        public void TestModifiedDttm()
        {
            BaseDatum Expected = new BaseDatum();
            BaseDatum Actual = new BaseDatum();
            Assert.AreEqual(Expected.ModifiedDTTM.ToString(), Actual.ModifiedDTTM.ToString());
        }
    }
}