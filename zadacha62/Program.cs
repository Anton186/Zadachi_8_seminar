// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7



void PrintMatrix(int[,] matrix)
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

int[,] SpiralMatrix(int[] arr)
{
  int n = 4;
  int[,] matr = new int[n, n];
  int m = n / 2,
      len = n,
      count = 0;
  for (int i = 0; i < m; i++)
  {
    // Cлева направо
    for (int j = 0; j < len; j++) matr[i, i + j] = arr[count++];
    // Cверху вниз
    for (int j = 1; j < len; j++) matr[i + j, n - i - 1] = arr[count++];
    len -= 2;
    // Cправа налево
    for (int j = len; j >= 0; j--) matr[n - i - 1, i + j] = arr[count++];
    // Cнизу вверх
    for (int j = len; j >= 1; j--) matr[i + j, i] = arr[count++];
  }
  return matr;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
int[,] matrix = SpiralMatrix(array);
Console.WriteLine("Спирально заполненая матрица: ");
PrintMatrix(matrix);