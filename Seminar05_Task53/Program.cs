// **Задача 53:**Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
Write("Введите строку 1: ");
int a = int.Parse(ReadLine()!);
Write("Введите строку 2: ");
int b = int.Parse(ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
ChangeRows(array, a, b);
PrintArray(array);



int[,] GetArray(int m, int n, int minValue, int maxValue)// функция для заполнения 2-мерного массива рандомными элементами
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);// обращаемся к каждому элементу массива и складывем рандомные числа
    }
  }
  return result;
}

void PrintArray(int[,] inArray)// функция вывода 2-мерного массива
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");// сначала записываем все элементы перврго массива, потом все элементы второго массива и т.д
    }
    WriteLine();//переносим на новую строчку
  }
}

void ChangeRows(int[,] inArray, int a, int b)// функция меняет строки массива местами на вход принимает 2-мерный массив строку(a) и строку(b)
{

  for (int i = 0; i < inArray.GetLength(1); i++)// циклом перебираем индексы строк
  {
    int k = inArray[a - 1, i];// в переменную положили значение первого элемента первой строчки
    inArray[a - 1, i] = inArray[b - 1, i];// поменяли местами элементы первой и второй строчки
    inArray[b - 1, i] = k;// записали в переменную значение первого элемента второй строчки
  }
}