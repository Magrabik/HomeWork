
// Задача 2: Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int RandomInt (int intCapacity) // Генерация случайного числа с заданой разрядностью
{
    if (intCapacity <= 0)
    {
        System.Console.WriteLine("Что то тут написано ");
        intCapacity = 1;
    }
    double dblPower = Convert.ToDouble(intCapacity);
    return new Random().Next(Convert.ToInt16(Math.Pow(10.0, dblPower - 1)), Convert.ToInt16(Math.Pow(10.0, dblPower)));
}

int TakeLastDigit(int intNumber) 
{
    return Math.Abs((intNumber % 10));
}

int ReduceCapacity(int intNumber) 
{
    return (intNumber / 10);
}

System.Console.Clear();
int intNumber = RandomInt(3);
int intTemp = int.Parse($"{TakeLastDigit(ReduceCapacity(ReduceCapacity(intNumber)))}{TakeLastDigit(intNumber)}");
System.Console.WriteLine($"Число, состоящее из первой и третьей цифры трехзначного числа {intNumber}, равно {intTemp}");
