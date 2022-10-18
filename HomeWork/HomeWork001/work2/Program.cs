System.Console.WriteLine("Введите первое число");
string vol1 = Console.ReadLine();
int a = Convert.ToInt32(vol1);

System.Console.WriteLine("Введите второе число");
string vol2 = Console.ReadLine();
int b = Convert.ToInt32(vol2);

System.Console.WriteLine("Введите третье число");
string vol3 = Console.ReadLine();
int c = Convert.ToInt32(vol3);

if (a < b && b < c)
{
    System.Console.WriteLine(c);
}
if (a < b && b > c)
{
    System.Console.WriteLine(b);
}
if (a > b && b > c)
{
    System.Console.WriteLine(a);
}
