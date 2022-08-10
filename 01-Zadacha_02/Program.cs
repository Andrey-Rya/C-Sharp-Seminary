// Программа на входе имеет 2 числа а на выходе показывает числа max и min
Console.WriteLine("Введите число a: ");// вводим число А
int numberA = Convert.ToInt32(Console.ReadLine()); // запоминаем А
Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());// запоминаем B
if (numberA > numberB)
{
    int max = numberA;
    int min = numberB;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
else
{
    int max = numberB;
    int min = numberA;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
