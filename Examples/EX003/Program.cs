using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a % 2 == 0 && a > 0 )
{
  WriteLine ($"{a} -> Да");
}
else
{
 WriteLine ($"{a} -> Нет");
}

