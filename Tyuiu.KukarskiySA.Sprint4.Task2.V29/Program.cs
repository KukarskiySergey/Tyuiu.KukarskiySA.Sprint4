using Tyuiu.KukarskiySA.Sprint4.Task2.V29.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Одномерные массивы(генератор случайных чисел)                  *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #29                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный      *");
Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение четных      *");
Console.WriteLine("* элементов массива.                                                   *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Массив из 11 случайных чисел                                         *");

Random random = new Random();
int[] array = new int[11];

// Заполнение массива случайными числами от 1 до 8
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 9);
}

Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int productOfEvens = dataService.Calculate(array);

Console.WriteLine($"Произведение четных элементов массива: {productOfEvens}");
Console.WriteLine("************************************************************************");
Console.ReadLine();