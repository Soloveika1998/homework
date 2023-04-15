Console.Write("Введите координаты 3-х точек ");

int ax = int.Parse(Console.ReadLine()!);
int ay = int.Parse(Console.ReadLine()!);
int az = int.Parse(Console.ReadLine()!);
int bx = int.Parse(Console.ReadLine()!);
int by = int.Parse(Console.ReadLine()!);
int bz = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow((bx-ax), 2) + Math.Pow((by-ay), 2) + Math.Pow((bz-az), 2));

  Console.WriteLine("Расстояние между точками = " +distance);
