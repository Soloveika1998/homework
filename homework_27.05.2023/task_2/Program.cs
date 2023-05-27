// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите значение M и N соответственно ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
while (m >= n)
{
  Console.Write("Введите значение M и N так, чтобы M было меньше N ");
  m = int.Parse(Console.ReadLine());
  n = int.Parse(Console.ReadLine());
}

int RecSummNaturalNumber (int m, int n)
{
  if (m > n) return 0; 
  else return m + RecSummNaturalNumber (m + 1 , n);
}
Console.WriteLine(RecSummNaturalNumber(m, n));