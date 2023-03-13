//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами

// mas = [[1, 2, 3],
//  [4, 5, 6]]
// mas[0][2]

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)// функция возвращает 2-мерный массив, на вход принимает 2 агумента, кол-во массивов(m) и кол-во элементов в каждом массиве(n)
{
  int[,] result = new int[m, n];// создали переменную в которую будем складывать кол-во массивов(m) и кол-во элементов в каждом массиве(n)
  for (int i = 0; i < m; i++)// первым циклом проходим массивам
  {
    for (int j = 0; j < n; j++)// второй цикл проходит по элементам массива
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);// обращаемся к каждому элементу массива и складывем рандомные числа
    }
  }
  return result;// возвращаем реезультат
}

void PrintArray(int[,] inArray)// функция вывода 2-мерного массива в консоль
{
  for (int i = 0; i < inArray.GetLength(0); i++)// первым циклом проходим по массивам
  {
    for (int j = 0; j < inArray.GetLength(1); j++)// второй проходит по элементам
    {
      Console.Write($"{inArray[i, j]} ");// сначала записываем все элементы перврго массива, потом все элементы второго массива и т.д
    }
    Console.WriteLine();//переносим на новую строчку
  }
}