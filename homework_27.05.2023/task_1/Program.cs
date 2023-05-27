// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введите значение N ");
int n = int.Parse(Console.ReadLine());
void RecNaturalNumber (int n)
{
  if (n==0) return; 
  else 
  {
    Console.Write(" " +n);
    RecNaturalNumber(n-1);
  }
}
RecNaturalNumber(n);