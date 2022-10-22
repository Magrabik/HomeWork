
// Задача 3: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int number = ReadInt("Введите число ");
int count = number.ToString().Length;
System.Console.WriteLine(MakeArray(number, count));





int ReadInt(string massage)
{
    System.Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        System.Console.WriteLine("Третей цифры нет ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;


    }
    return result;
}
