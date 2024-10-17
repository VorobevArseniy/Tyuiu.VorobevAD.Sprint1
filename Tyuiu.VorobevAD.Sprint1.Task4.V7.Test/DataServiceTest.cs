using Tyuiu.VorobevAD.Sprint1.Task4.V7.Lib

namespace Tyuiu.VorobevAD.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService obj = new DataService();
            Assert.AreEqual(obj.Calculate(3, 4), 25);
        }
    }
}