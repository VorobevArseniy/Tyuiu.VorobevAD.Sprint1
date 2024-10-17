using Tyuiu.VorobevAD.Sprint1.Task4.V7.Lib;

namespace Tyuiu.VorobevAD.Sprint1.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService obj = new DataService();

            Console.WriteLine("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ответ: " + obj.Calculate(x, y));
            Console.WriteLine("Сделал Воробьев Арсений РППб-24-1");
        }
    }
}
