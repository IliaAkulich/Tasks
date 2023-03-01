// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число: ");
int numberА = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberА < numberB)
{
    Console.WriteLine($"Число {numberB} больше {numberА}");
}
else 
{
    Console.WriteLine($"Число {numberА} больше {numberB}");
}