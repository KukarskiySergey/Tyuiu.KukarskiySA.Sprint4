﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task1.V1.Lib
{
    public class DataService : ISprint4Task1V1
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
