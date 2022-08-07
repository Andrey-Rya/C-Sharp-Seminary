// программа проверки является ли первое число квадратом второго

Console.WriteLine("Введите число A: ");// вводим число А
int numberA = Convert.ToInt32(Console.ReadLine()); // запоминаем А
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());// запоминаем B
if ((numberA / numberB) == numberB)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
