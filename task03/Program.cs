// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Clear();
Write("Введите первое неотрицательное число: ");
int m = int.Parse(ReadLine()!);
Write("Введите второе неотрицательное число: ");
int n = int.Parse(ReadLine()!);
WriteLine($"Значение функции Аккермана равно {Akkerman(m, n)}");