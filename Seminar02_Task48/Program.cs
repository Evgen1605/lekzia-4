// **Задача 48:** Задайте
// двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: A[i][j] = i + j.
//Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5

using System;
using static System.Console;// эти 2 строчки заменяют Console. теперь на каждом вызове консоли можно не писать

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray(int m, int n)// создаём функцию для заполнения массивов
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = i + j;// обращаемся к каждому элементу массива и складывем числа попеременно
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