﻿using Tyuiu.VorobevAD.Sprint1.Task2.V20.Lib;

namespace Tyuiu.VorobevAD.Sprint1.Task2.V20
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

            Console.WriteLine("Ответ: " + obj.CalculateSquaresSumm(x, y));
            Console.WriteLine("Сделал Воробьев Арсений РППб-24-1");
        }
    }
}
