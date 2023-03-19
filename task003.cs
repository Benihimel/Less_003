﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberN; i++)
{
    Console.WriteLine($"Table of cubes of numbers {i}: {Math.Pow(i, 3)}");
}