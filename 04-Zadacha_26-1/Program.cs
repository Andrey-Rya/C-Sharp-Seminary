// программа принимает на вход число и выдает количество цифр в нём
// решение через строку
Console.Clear();
Console.Write("Введите число: "); // ввод числа  в строку
int n = Convert.ToInt32(Console.ReadLine()); // переводим строку в число 
n = Math.Abs(n); // проверка на отрицательные числа
string s = Convert.ToString(n);
Console.Write(s.Length);

