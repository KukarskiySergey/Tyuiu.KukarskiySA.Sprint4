using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEvenNumbers = false;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    product *= number;
                    hasEvenNumbers = true;
                }
            }

            // Если не было четных чисел, вернуть 0
            return hasEvenNumbers ? product : 0;
        }
    }
}
