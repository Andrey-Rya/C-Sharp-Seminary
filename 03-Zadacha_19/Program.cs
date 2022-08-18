// программа принимает на вход 5-ти значное число
// и проверяет является ли оно палиндромом (зеркальным)

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// string[] arr = { "x>0;y>0", "x<0;y>0", "x<0;y<0", "x>0;y<0" }; // записываем все условия в массив
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


// второй вариант решения вывода первой и последней цифры 
// случайного трехзначного числа
// string s = new string().Next(100, 1000).ToString(); // конвертируем рандом число в строку
// Console.WriteLine($"Для проверки: {s}");
// int first = int.Parse(s[0].ToString()); // находим в строке первое чиcло (нулевой эл-т)
// int last = int.Parse(s[s.Length - 1].ToString()); // // находим в строке последнее число [s.Length - 1]
// Console.WriteLine($"{first}{last}"); // печатаем их в терминале


// Console.WriteLine("Hello, World!");
