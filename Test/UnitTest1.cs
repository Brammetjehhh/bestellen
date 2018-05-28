using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            database.DbConnect dbConnect = new database.DbConnect();
            string s = dbConnect.getPassword("Bram");
            Assert.IsNotNull(s);
        }
    }
}
