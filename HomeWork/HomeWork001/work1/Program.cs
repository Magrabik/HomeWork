//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
string volue1 = Console.ReadLine();
int a = Convert.ToInt32(volue1);

System.Console.WriteLine("Введите второе число");
string volue2 = Console.ReadLine();
int b = Convert.ToInt32(volue2);

if(a>b)
{
    Console.WriteLine(volue1);
}

if(a<b)
{
   Console.WriteLine(volue2);
}
