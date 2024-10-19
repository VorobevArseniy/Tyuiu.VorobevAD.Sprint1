using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VorobevAD.Sprint1.Task5.V6.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int n = (k - 1) % 7 + 1;
            return (n);
            throw new NotImplementedException();
        }
    }
}
