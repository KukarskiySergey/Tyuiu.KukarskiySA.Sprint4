using Tyuiu.KukarskiySA.Sprint4.Task3.V28.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Двумерные массивы(ввод с клавиатуры)                           *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #13                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7.                       *");
Console.WriteLine("* Найдите сумму четных элементов массива.                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* 6, 3, 5, 7, 5,                                                       *");
Console.WriteLine("* 3, 5, 7, 4, 5,                                                       *");
Console.WriteLine("* 5, 6, 4, 5, 4,                                                       *");
Console.WriteLine("* 7, 4, 7, 3, 3,                                                       *");
Console.WriteLine("* 4, 6, 5, 5, 6,                                                       *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int[,] matrix = {
    {6, 3, 5, 7, 5},
    {3, 5, 7, 4, 5},
    {5, 6, 4, 5, 4},
    {7, 4, 7, 3, 3},
    {4, 6, 5, 5, 6}
};

int sumOfEvenElements = dataService.Calculate(matrix);

Console.WriteLine($"Сумма четных элементов: {sumOfEvenElements}");
Console.WriteLine("************************************************************************");
Console.ReadLine();