// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int ReadNumber(string message) // Ввод числа из консоли.
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


int[,] GetMatrix(int rows, int columns, int leftRange = 0, int rightRange = 9) // Наполнение массива случайными числами.
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

void SearchInMatrix(int[,] matrix)// метод считает блаблабла и печатает
{
    int count = 0; //создали счётчик и он ноль
    for (int k = 0; k < 10; k++) //берем какое то число К и считаем его до максимального значение
    {
        for (int i = 0; i < matrix.GetLength(0); i++)// идём по массиву по столбцам пока не закончатся столбцы
        {
            for (int j = 0; j < matrix.GetLength(1); j++)//идём по строкам пока не закончатся строки
            {
                if(matrix[i,j] == k) count++; //если число в этом индексе совпадает с числом К то счётчик увеличиваем
            }
        }
        if(count != 0) // если счётчик не равен 0 то работаем
        {
            Console.WriteLine($"Элемент {k} встречается {count} раз");//выводим текст с счётчиком
            count = 0;// обнуляем счётчик
        }
    }
}

int rows = ReadNumber("Введите количество строк матрицы: ");
int columns = ReadNumber("Введите количество столбцов матрицы: ");

int[,] matr = GetMatrix(rows, columns);

Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
Console.WriteLine();
SearchInMatrix(matr);
