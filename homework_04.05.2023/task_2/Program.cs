double[,] CreateArray(int m, int n, int leftSide, int rightSide)
{
double[,] array = new double[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Math.Round(random.Next(leftSide, rightSide) + random.NextDouble(), 2);
    }
}
return array;
}

void PrintArray(double [,] array)
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

void SearchValueByIndexInArray(double [,] array)
{
  Console.Write("Введите номер строки ");
  int row = int.Parse(Console.ReadLine());
  Console.Write("Введите номер столбца ");
  int column = int.Parse(Console.ReadLine());
  if (row <= array.GetLength(0) && column <=array.GetLength(1)) 
  {
    Console.WriteLine(array[row-1, column-1]);
  }
  else 
  {
    Console.WriteLine("Такого числа в массиве нет");
  }
}
double [,] array = CreateArray(3,3, 100 ,120);
PrintArray(array);
SearchValueByIndexInArray(array);