// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите два положительных числа M и N соответственно ");
  long m = long.Parse(Console.ReadLine());
  long n = long.Parse(Console.ReadLine());

long AkkermanRec (long m, long n)
{
  long result = 0;
  if (m == 0) result = n + 1;
  if (m > 0 && n == 0) result = AkkermanRec(m - 1, 1);
  if (m > 0 && n > 0) result = AkkermanRec(m - 1, AkkermanRec(m, n - 1));
  return result;
}

Console.WriteLine(AkkermanRec (m, n));