using Tyuiu.VorobevAD.Sprint1.Task3.V16.Lib;

namespace Tyuiu.VorobevAD.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService obj = new DataService();
            Assert.AreEqual(obj.CoeffOfQuadraticEquation(3, 2), -5);
        }
    }
}