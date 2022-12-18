using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);
WriteLine("Введите число c: ");
int c = int.Parse(ReadLine()!);
int max = a;
if (a > b)
{
   max = a;
}
else
{
   max = b;
}
if (max > c)
{
  max = max;
}
else
{
  max = c;
}
WriteLine ($"{max}");