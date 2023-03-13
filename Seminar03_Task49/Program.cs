// **Задача 49:** Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 2 3 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4

// 1 **4** 3 **16**

using System;
using static System.Console;// эти 2 строчки заменяют Console теперь на каждом вызове консоли можно не писать


Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
PrintArray(ChangeArray(array));

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

int[,] ChangeArray(int[,] array)// функция по изменению массива 
{
  for (int i = 0; i < array.GetLength(0); i++)// первый цикл считает строки массива (GetLength(0) считает кол-во массивов)
  {
    for (int j = 0; j < array.GetLength(1); j++)// вложенный цикл считает колонки массива (GetLength(1) считает кол-во элементов в массивах)
    {
      if (i % 2 == 1 && j % 2 == 1)// проверяем если строки и колонки нечётные
      {
        array[i, j] *= array[i, j];// то элементы возводим в квадрат (т.е умножаем саму на себя)
      }
    }
  }
  return array;// возвращаем массив
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

