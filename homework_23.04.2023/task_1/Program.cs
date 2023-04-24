int[] CreateArray(int length, int leftSide, int rightSide)
{
int[] array = new int[length];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = random.Next(leftSide, rightSide);
return array;
}

void PrintArray(int[] array)
{
foreach (int element in array)
Console.Write($"{element} |");
Console.WriteLine(" ");
}

void searchArray(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      count++;
  }
  Console.WriteLine("Четные числа встречаются " +count+ " раз!");
}

int [] array = CreateArray(10, 100, 999);
PrintArray(array);
searchArray(array);