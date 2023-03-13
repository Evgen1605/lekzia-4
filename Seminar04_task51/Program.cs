// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
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
WriteLine($"Сумма элементов главной диагонали = {GetSumDiag(array)}");

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

int GetSumDiag(int[,] array)//функция сложения чисел главной диогонали 2-мерного массива
{
  int diagonal = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);// в переменную складываем результат проверки кол-ва строк(array.GetLength(0)) меньше кол-ва столбцов(array.GetLength(1)) если true, то возвращаем строки, если false то столбцы 
  int sum = 0;
  for (int i = 0; i < diagonal; i++)// запускаем цикл, на кол-во элементов
  {
    sum += array[i, i];// в сумму складывем индексы элементов
  }
  return sum;// возвращаем полученный результат
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