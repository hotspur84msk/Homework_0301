﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num;

Console.Write($"Чётные числа от 1 до {num} -> ");

for (int i = 0; i < num; i++)
{
    if(result % 2 == 0)
    {
        Console.Write($"{result}, ");
    }
    result--;
}