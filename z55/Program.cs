// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

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

void ChangeMatrix (int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
}

void ChangeMatrix1 (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)// идём по строкам пока не закончатся столбцы
    {
        for (int j = 0; j < matrix.GetLength(0); j++)//идём по столбцам пока не закончатся строки
        {
            Console.Write($"{matrix[j,i]}\n"); //только печатаем, не делая новую матрицу.
            //печатаем символ по адресу столбец, строка затем \n значит табуляция
        }
        Console.WriteLine(); //переносим на новую строку после окончания этой
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
Console.WriteLine("Измененная матрица:");
ChangeMatrix1(matr);


