// **Задача 69:**Напишите программу,
// которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8

using System;
using static System.Console;

Clear();
Write("Введите A: ");
int a = int.Parse(ReadLine()!);
Write("Введите B: ");
int b = int.Parse(ReadLine()!);

Write($"число {a} в степени {b} равно {ExponentiationAinB(a,b)}");

int ExponentiationAinB(int number, int rank)
{
  if (rank == 0)
  {
    return 1;
  }
  return (number * ExponentiationAinB(number, rank -1));
}