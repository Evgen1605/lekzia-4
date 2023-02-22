Console.Clear();

string[,] table = new string[2, 5]; // Указываем что у нас будет 2 строки и 5 столбцов

// по умолчанию строки у нас инициируются пустой строкой (String.Empty)
//Чтобы обратиться к нужному элементу, указываем имя массива и в квадратных скобках пишем индекс
// строки(1) и индекс столбца (5)
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4] Столбцы
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4] строки

table[1, 2] = "Слово";

for (int row = 0; row < 2; row++)
{
  for (int column = 0; column < 5; column++)
  {
    Console.Write($"{table[row, column]}*");
  }
  Console.WriteLine();
}
Console.WriteLine();


void PrintArray(int[,] matr) // функция печати матрицы
{
  for (int i = 0; i < matr.GetLength(0); i++) // Для тройки указываем имя массива и новый функционал GetLength(0). 0 в качестве аргумента означает количество строк.
  {
    for (int j = 0; j < matr.GetLength(1); j++) //Аналогично и для четвёрки: пишем имя массива, точку и GetLength(1). 
    {
      Console.Write($"{matr[i , j]} ");
    }
    Console.WriteLine();
  }
}

void FilArray(int[,] matr) //дополнительный метод, который будет заполнять нашу матрицу случайными числами
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i,j] = new Random().Next(1, 10);
    }
  }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix); // выводим функцию 
FilArray(matrix);
Console.WriteLine();
PrintArray(matrix);