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
if (ValidateNumber(number))
{
    int lastDigit = (number / 10) % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {lastDigit}");
}