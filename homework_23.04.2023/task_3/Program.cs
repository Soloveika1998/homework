double[] CreateArray(int length, int leftSide, int rightSide)
{
double[] array = new double[length];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(random.Next(leftSide, rightSide) + random.NextDouble(), 2);
return array;
}

void PrintArray(double[] array)
{
foreach (double element in array)
Console.Write($"{element} |");
Console.WriteLine(" ");
}

void differenceElementArray(double[] array)
{
  double difference;
  double minElement = array[0];
  double maxElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= maxElement)
      maxElement = array[i];
    else if (array[i] <= minElement)
      minElement = array[i];
  }
  difference = Math.Round(maxElement-minElement, 2);
  Console.WriteLine("Мксимальный элемент равен " +maxElement+ ", минимальный " +minElement);
  Console.WriteLine("Разница равна " +difference);
}

double [] array = CreateArray(8, -10, 10);
PrintArray(array);
differenceElementArray(array);