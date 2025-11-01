using System;
using Tyuiu.BazilevichAV.Sprint4.Task2.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)            *");
Console.WriteLine("* Задание #2                                              *");
Console.WriteLine("* Вариант #2                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов     *");
Console.WriteLine("* заполненный значениями в диапазоне от 2 до 5 подсчитать *");
Console.WriteLine("* произведение нечетных элементов массива.                *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Random rnd = new Random();
Console.WriteLine("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    numsArray[i] = rnd.Next(1,8);
}

Console.WriteLine();
Console.WriteLine("Массив:");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine("Произведение нечетных элеметов массива = " + res);
Console.ReadKey();