using Tyuiu.KukarskiySA.Sprint4.Task0.V18.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Одномерные массивы(статический ввод)                           *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #18                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный      *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму       *");
Console.WriteLine("* нечетных элементов массива.                                          *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Массив {9, 8, 7, 6, 5, 7, 3, 2, 7, 3}                                *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

int sum = dataService.GetSumOddArrEl(array);

Console.WriteLine(sum);
Console.WriteLine("************************************************************************");
Console.ReadLine();