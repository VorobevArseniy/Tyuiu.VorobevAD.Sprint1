using Tyuiu.VorobevAD.Sprint1.Task1.V2.Lib;

namespace Tyuiu.VorobevAD.Sprint1.Task1.V2.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckCalculateValid()
    {
        DataService obj = new DataService();
        Assert.AreEqual(obj.Calculate(5, 10), 5);
    }
}