using Tyuiu.VorobevAD.Sprint1.Task2.V20.Lib;

namespace Tyuiu.VorobevAD.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalc()
        {
            DataService obj = new DataService();
            Assert.AreEqual(obj.CalculateSquaresSumm(2, 3), 13);
        }
    }
}