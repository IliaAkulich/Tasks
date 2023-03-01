//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;


if (numberB > max)
{
    max = numberB;
    Console.WriteLine ($"Число {max} максимальное");
}
if (numberC > max)
{
    max = numberC;
    Console.WriteLine ($"Число {max} максимальное");
}    
