using Tyuiu.VorobevAD.Sprint1.Task1.V2.Lib;

namespace Tyuiu.VorobevAD.Sprint1.Task1.V2;

internal class Program
{
    static void Main(string[] args)
    {
        DataService obj = new DataService();
        
        
        Console.WriteLine("Введите первое число: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ответ: " + obj.Calculate(x, y));
        Console.WriteLine("Сделал Воробьев Арсений РППб-24-1");
    }
}
