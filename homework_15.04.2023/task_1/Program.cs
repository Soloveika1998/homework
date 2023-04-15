Console.Write("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine()!);
if ((number / 10000) == (number % 10) && ((number % 100) / 10) == ((number / 1000) % 10))
  Console.Write("Число " +number+ " является палиндром");
else
  Console.Write("Число " +number+ " не является палиндром");
