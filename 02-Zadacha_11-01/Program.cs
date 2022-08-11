// второй вариант решения вывода первой и последней цифры случайного трехзначного числа
string s = new Random().Next(100, 1000).ToString(); // конвертируем рандом число в строку
Console.WriteLine($"Для проверки: {s}");
int first = int.Parse(s[0].ToString()); // находим в строке первое чиcло (нулевой эл-т)
int last = int.Parse(s[s.Length - 1].ToString()); // // находим в строке последнее число [s.Length - 1]
Console.WriteLine($"{first}{last}"); // печатаем их в терминале
