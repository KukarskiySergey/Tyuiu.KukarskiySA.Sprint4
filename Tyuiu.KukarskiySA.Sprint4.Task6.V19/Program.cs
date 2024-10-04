using Tyuiu.KukarskiySA.Sprint4.Task6.V19.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Двумерные массивы(генератор случайных чисел)                   *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #19                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан строковый массив данных. Используя класс Array                   *");
Console.WriteLine("* подсчитайте количество элементов, длина которых больше 5.            *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Строковый массив данных                                              *");
Console.WriteLine("* [Chrome, Firefox, Safari, Opera, Edge, Internet Explorer, Brave]     *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

string[] browsers = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

int countOfLongNames = dataService.Calculate(browsers);

Console.WriteLine($"Количество элементов, длина которых больше 5: {countOfLongNames}");
Console.WriteLine("************************************************************************");
Console.ReadLine();