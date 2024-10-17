using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VorobevAD.Sprint1.Task2.V20.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task2V20
    {
        public int CalculateSquaresSumm(int value, int valueTwo)
        {
            double a = value;
            double b = valueTwo;

            return (Convert.ToInt32(Math.Pow(a, 2) + Math.Pow(b, 2)));
            throw new NotImplementedException();
        }
    }
}
