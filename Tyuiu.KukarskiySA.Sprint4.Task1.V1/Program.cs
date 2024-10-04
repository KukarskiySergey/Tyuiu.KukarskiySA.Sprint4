using Tyuiu.KukarskiySA.Sprint4.Task1.V1.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Одномерные массивы(ввод с клавиатуры)                          *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #1                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный      *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 9 подсчитать сумму       *");
Console.WriteLine("* четных элементов массива.                                            *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Ввод данных с клавиатуры: 8, 2, 7, 5, 0, 7, 4, 7, 5, 7               *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int[] array = new int[10];
Console.WriteLine("Введите 10 чисел в диапазоне от 0 до 9:");

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int sumOfEvens = dataService.Calculate(array);

Console.WriteLine($"Сумма четных элементов массива: {sumOfEvens}");
Console.WriteLine("************************************************************************");
Console.ReadLine();