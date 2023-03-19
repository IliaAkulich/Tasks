// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int NumberDay = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int NumberDay)
{
    if (NumberDay == 6 || NumberDay == 7)
    {
        Console.WriteLine("Выходной!");
    }
    else if (NumberDay < 1 || NumberDay > 7)
    {
        Console.WriteLine("Это вообще не день недели");
    }
    else
        Console.WriteLine("Очень жаль, но это не выходной :(");
}

CheckingTheDayOfTheWeek(NumberDay);
