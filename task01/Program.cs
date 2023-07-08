// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
using static System.Console;

string PrintNumber(int n)
{
    if (n == 1) return "1";
    return n.ToString() + ", " + PrintNumber(n - 1);
}

Clear();
Write("Введите число: ");
int nums = int.Parse(ReadLine()!);
WriteLine(PrintNumber(nums));