// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int ReadNumber(string message) // Ввод числа из консоли.
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10) // Наполнение массива случайными числами.
{
  int[,] matrix = new int[rows, columns];
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в консоль.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}

void SortMatrixMinMax(int[,] matrix) 
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      int minPosition = j;
      for (int k = j + 1; k < matrix.GetLength(1); k++)
      {
        if (matrix[i, k] < matrix[i, minPosition])
        {
          minPosition = k;
        }
      }
      int temp = matrix[i, j];
      matrix[i, j] = matrix[i, minPosition];
      matrix[i, minPosition] = temp;
    }
  }
}


int m = ReadNumber("Введите количество строк матрицы: ");
int n = ReadNumber("Введите количество столбцов матрицы: ");

int[,] matr = GetMatrix(m, n);

Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
Console.WriteLine();

SortMatrixMinMax(matr);
Console.WriteLine("Отсортированная матрица:");
PrintMatrix(matr);