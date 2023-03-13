﻿// **Задача 63:**Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5-> "1, 2, 3, 4, 5"

// N = 6-> "1, 2, 3, 4, 5, 6"


using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine()!);

// for (int i = 1; i <= n; i++)
// {
//   Write($"{i} ");
// }
// WriteLine();

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)// функция выдаёт натуральные числа в промежутке от 1 до заданное пользователем(n) например 4
{
  if (end == 1)// проверяет пока конечное число (заданное пользователем) не приравняется 1
  {
    WriteLine(end);
    return "1";// возвращает строку начиная с 1
  }
  string s = PrintNumbers(end - 1) + " " + end.ToString();// возвращает строку s которая вызывает функцию сначала PrintNumbers(4), потом PrintNumbers(3), потом PrintNumbers(2), потом PrintNumbers(1), затем начинает считать с конца где return "1", подставляя сначала "1" + "2", потом "1 2" + "3", потом "1 2 3" + "4"
  WriteLine(s);// выводит в консоль
  return s;// возвращает строку s 
}