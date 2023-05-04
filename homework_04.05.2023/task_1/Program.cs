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

PrintArray(CreateArray(5,5, 100 ,120));
