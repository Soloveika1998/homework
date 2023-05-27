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

void PrintArray(int [,] matrix)
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

void SortArrayByRowsFromMaxToMin (int [,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
      for (int k = 0; k < matrix.GetLength(1)-1; k++)
      {
        if (matrix[i,k] < matrix[i,k+1])
          {
            int temp = matrix[i,k];
            matrix[i,k] = matrix[i,k+1];
            matrix[i,k+1] = temp;
          }
      }
    }
  }
}

void task54 ()
{
  // Задача 54: Задайте двумерный массив. Напишите программу, 
  // которая упорядочит по убыванию элементы каждой строки двумерного массива.
  int rows = 4;
  int columns = 4;
  int [,] array = new int [rows, columns];
  FillArray(array);
  PrintArray(array);
  SortArrayByRowsFromMaxToMin(array);
  PrintArray(array);
}

task54 ();