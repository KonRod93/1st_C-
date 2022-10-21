// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string numberAStr = Console.ReadLine();
int numberA = int.Parse(numberAStr);

Console.WriteLine("Введите второе число");
string numberBStr = Console.ReadLine();
int numberB = int.Parse(numberBStr);

if (numberA > numberB)
{
    Console.WriteLine("Первое число " + numberA + " больше, чем второе" + numberB);
}
else
{
    Console.WriteLine("Второе число " + numberB + " больше, чем первое" + numberA);
}