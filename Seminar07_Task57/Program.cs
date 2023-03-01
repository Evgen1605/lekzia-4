// /* **Задача 57:**Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза

// 1 встречается 1 раз

// 2 встречается 1 раз

// 8 встречается 1 раз

// 9 встречается 3 раза

// 1, 2, 3,4, 6, 1, 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза*\

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int minValue, int maxValue)  //функция создания рандомных двумерных массивов
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

// функция вывода в косоль
void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[] GetRowArray(int[,] inArray) //получаем массив строк, на вход получает двумерный, возращает одномерный массив
{
  int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)]; // создали одномерный массив: int[] result, надлину равную произведение строк на кол-во элементов в строке, т.е умножаем кол-во строк на кол-во столбцов 
  int index = 0;// создали переменную index чтобы обращаться к элементам result
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)// перебираем все элементы вложенным циклом
    {
      result[index] = inArray[i, j]; //кладём в result index чисел, тем самым в result будут все элементы массива inArray
      index++;// увеличиваем индекс на 1
    }
  }
  return result; // возвращаем result
}

void SortArray(int[] inArray) // функция сортирует элементы
{
  for (int i = 0; i < inArray.Length; i++)
  {
    for (int j = i; j < inArray.Length; j++)
    {
      if (inArray[i] > inArray[j])
      {
        int k = inArray[i];
        inArray[i] = inArray[j];
        inArray[j] = k;
      }
    }
  }
}

void PrintData(int[] inArray) // функция выводит сколько раз и какой элемент встретился в массиве
{
  int el = inArray[0];// создали переменную в которую изначально положили нулевой индекс массива inArray
  int count = 1;// переменная count отвечает за кол-во подряд идущих элементов
  for (int i = 1; i < inArray.Length; i++) // сравниваем текущий элемент с предыдущим
  {
    if (inArray[i] != el)
    {
      WriteLine($"{el} встречается {count} раз");
      el = inArray[i];
      count = 1;
    }else
    {
      count++;// если текущий элемент совпадает с предыдущим, то его увиличиваем на 1
    }
  }
  WriteLine($"{el} встречается {count} раз");
}