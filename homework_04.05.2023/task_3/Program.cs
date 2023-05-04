int[,] CreateArray(int m, int n, int leftSide, int rightSide)
{
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = random.Next(leftSide, rightSide);
    }
}
return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void FindAverageInArrayRows (int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    double summ=0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      summ = summ + array[i,j];
    }
    double average = summ/array.GetLength(1);
    Console.WriteLine(average);    
  }
}

int [,] array = CreateArray(3, 4, 1, 5);
PrintArray(array);
FindAverageInArrayRows(array);
