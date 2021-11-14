using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringTester;
using System.Linq;

namespace StringTester.Tests
{
    [TestClass]
    public class StringTest
    {

        public TestContext testContext { get; set; }
        private StringTester stringTester = new StringTester();
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Data.xml",
            "User",
            DataAccessMethod.Sequential)]


        [TestMethod]
        public void CheckString()
        {
            string userId = Convert.ToString(testContext.DataRow["userId"]);
            int count = Convert.ToInt32(testContext.DataRow["count"]);
            int result = stringTester.Complete(userId);
            Assert.AreEqual(count, result);

            //StringTester stringTester = new StringTester();
            //int actual = stringTester.Complete("");
            //int expected = 0;
            //Assert.AreEqual(expected, actual);
        }
    }
}