Console.Write("Введите случайное число ");

int number = int.Parse(Console.ReadLine()!);
int index = 1;
double cube;

while (index<=number) {
  cube = Math.Pow((index), 3);
  index++;
  Console.WriteLine(cube);
}