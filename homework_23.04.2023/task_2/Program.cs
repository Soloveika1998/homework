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

void summArray(int [] array)
{ 
  int summ = 0;
  for(int i = 1; i < array.Length; i = i+2)
  {
    summ = summ + array[i];
  }
  Console.WriteLine("Сумма элементов на нечетных позициях равна " +summ);
}

int [] array = CreateArray(8, 1, 10);
PrintArray(array);
summArray(array);