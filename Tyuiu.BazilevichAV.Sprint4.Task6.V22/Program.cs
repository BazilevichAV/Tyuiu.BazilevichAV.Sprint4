using System;
using Tyuiu.BazilevichAV.Sprint4.Task6.V22.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)            *");
Console.WriteLine("* Задание #5                                              *");
Console.WriteLine("* Вариант #22                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,    *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 1 до *");
Console.WriteLine("* 8. Найдите сумму четных элементов массива.              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

string[] weather = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

Console.WriteLine("Исходный массив:");
for (int i = 0; i <= weather.Length - 1; i++)
{
    Console.WriteLine(weather[i]);
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

string[] result = ds.Calculate(weather);

Console.WriteLine("Количество элементов длина которых равна 4 символам = " + result.Length);
Console.ReadKey();