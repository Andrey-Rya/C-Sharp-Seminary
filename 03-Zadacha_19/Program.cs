// программа принимает на вход 5-ти значное число
// и проверяет является ли оно палиндромом (зеркальным)

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number < 100000) // если number >=10000 и <=100 000 то делаем ниже
{
    Console.WriteLine();
    if (number / 10000 == number % 10 || number / 1000 == number % 100)
    {
        Console.WriteLine($"Число {number} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} - не является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число. Повторите ввод!");
}
