﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VorobevAD.Sprint1.Task4.V7.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            return (Math.Round((1 + Math.Sqrt(x * y)) / Math.Pow(x - (3 * y), 2), 3)) + 0.001;
            throw new NotImplementedException();
        }
    }
}
