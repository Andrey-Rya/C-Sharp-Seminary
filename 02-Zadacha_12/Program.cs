// программа принимает на вход 2 числа и выводить является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то выводит остаток
// от деления
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA % numberB == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {numberA % numberB}");
}
