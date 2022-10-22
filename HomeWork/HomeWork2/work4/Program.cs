// Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int PromptInt(string strDescription)
{
    try
    {
        System.Console.Write(strDescription);
        int intTemp = int.Parse(System.Console.ReadLine());
        return intTemp;
    }
    catch
    {
        System.Console.WriteLine("Введено некорректное значение.");
        int intException = PromptInt(strDescription);
        return intException;
    }
}

bool IsDayIsWeekend(int intNumberOfDay)
{
    if (intNumberOfDay < 1 || intNumberOfDay >7)
    {
        System.Console.Write("Введено некорректное значение.");
        return false;
    }
    else if (intNumberOfDay < 6)
    {
        System.Console.WriteLine("Это рабочий день!");
        return false;
    }
    else
    {
        System.Console.WriteLine("Это выходной!");
        return true;
    }
}

System.Console.Clear();
int intNumber = PromptInt("Введите номер дня недели (где 1 - понедельник, а 7 - воскресенье): ");
    if (IsDayIsWeekend(intNumber))
    {
       
    }
    else
    {
        
    }