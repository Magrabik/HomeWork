//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();
int a = Convert.ToInt32(num1);

System.Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();
int b = Convert.ToInt32(num2);

if(a>b)
{
    Console.WriteLine("max = a");
}

if(a<b)
{
   Console.WriteLine("max = b");
}
