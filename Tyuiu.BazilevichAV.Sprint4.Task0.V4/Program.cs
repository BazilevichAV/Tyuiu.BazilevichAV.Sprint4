using System;
using Tyuiu.BazilevichAV.Sprint4.Task0.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)             *");
Console.WriteLine("* Задание #0                                              *");
Console.WriteLine("* Вариант #4                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов     *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до *");
Console.WriteLine("* 9 подсчитать произведение четных элементов массива.     *");
Console.WriteLine("* {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}                          *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

Console.WriteLine("Исходный массив: ");
for (int i = 0; i <= numsArray.Length - 1; i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("Результирующий массив: ");

int res = ds.GetMultEvenArrEl(numsArray);
Console.WriteLine("Произведение четных элементов массива = " + res);

Console.ReadKey();