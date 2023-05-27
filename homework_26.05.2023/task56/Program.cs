void FillArray(int [,] matrix, int minValue = 0, int maxValue = 9)
{
  Random random = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = random.Next(minValue, maxValue);
    }
  }
}

void PrintMatrix(int [,] matrix)
{
  Console.WriteLine("Печать матрицы");
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} | ");
    }
    Console.WriteLine("\n");
  }
}

int [] FindLineSummElements (int [,] matrix, int sizeArray)
{
  int [] array = new int [sizeArray];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int summLine = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      summLine = summLine + matrix[i,j];
    }
    array[i] = summLine;
  }
  return array;
}

void FindLineMaxSummElement (int [] array)
{
  int numberMaxLine = 0;
  for (int i = 0; i < array.Length-1; i++)
  {
    if (array[numberMaxLine] < array[i+1]) numberMaxLine = i+1;
  }
  Console.WriteLine("Наибольшая сумма элементов в строке # " +numberMaxLine);
}

void task56 ()
{
  // Задача 56: Задайте прямоугольный двумерный массив. 
  // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
  int rows = 3;
  int columns = 3;
  int [,] array = new int [rows, columns];
  FillArray(array);
  PrintMatrix(array);
  FindLineMaxSummElement (FindLineSummElements(array, rows));
}

task56 ();