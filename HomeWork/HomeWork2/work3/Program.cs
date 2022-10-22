// Задача 3: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
     System.Console.WriteLine(message);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}


bool ValidateNumber(int number)
{
     if (number < 100 || number >= 1000)
     {
          System.Console.WriteLine("Это число не трехзначное");
          return false;
     }
     return true;
}

int number = Prompt("Введите трехзначное число: ");
if(ValidateNumber(number))
{
     int lastDigit = number % 10;
     System.Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");
}