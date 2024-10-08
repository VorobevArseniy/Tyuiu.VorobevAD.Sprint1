using Tyuiu.VorobevAD.Sprint1.Task0.V30.Lib;

namespace Tyuiu.VorobevAD.Sprint0.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidSetCount()
        {
            DataService obj = new DataService();
            Assert.AreEqual(obj.Calculate(), 96);
        }
    }
}