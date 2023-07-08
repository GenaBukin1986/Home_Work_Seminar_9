// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    return m + SumNumbers(m + 1, n);
}

Clear();
Write("Введите первое число: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);
WriteLine($"Сумма натуральных элементов в промежутке от {num1} до {num2} равна {SumNumbers(num1, num2)}");