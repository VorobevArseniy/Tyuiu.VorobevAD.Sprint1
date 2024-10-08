using Tyuiu.VorobevAD.Sprint0.Task0.V30.Lib;

namespace Tyuiu.VorobevAD.Sprint0.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidSetCount()
        {
            Assert.AreEqual(DataService.SetCount(), 96);
        }
    }
}