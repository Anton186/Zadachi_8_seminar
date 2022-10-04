// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.


int[,] GetMatrix(int size1, int size2, int leftRange, int rightRange) // Наполнение массива случайными числами.
{
  int[,] matrix = new int[size1, size2];
  Random rand = new Random();
  for (int i = 0; i < size1; i++)
  {
    for (int j = 0; j < size2; j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в терминал.
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

void ChangeMatrix(int[,] matrix) ///метод замены первой и последней строки массива;
{
    int temp;
    for (int j = 0; j < matrix.GetLength(1); j++) //идём по столбцам, пока столбцы не кончатся
    {
        temp = matrix[0,j]; //в темп положили значение строка 1 столбец J
        matrix[0,j]=matrix[matrix.GetLength(0)-1,j]; 
        // нужно в строку 1 столбец J положить значение строка последняя, столбец J
        matrix[matrix.GetLength(0)-1,j] = temp;// в строка последняя столбец J - положить temp
    }
}

Console.WriteLine("Введите количество строк матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] matr = GetMatrix(number1, number2, 1, 100);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
Console.WriteLine();

ChangeMatrix(matr);
Console.WriteLine("Измененная матрица:");
PrintMatrix(matr);