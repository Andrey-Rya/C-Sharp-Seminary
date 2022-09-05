// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N с помощью рекурсии

Console.Clear();
int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");

void PrintNumbers(int number, int n)
{
    if (number == n-1)
    {
        return;
    }
    PrintNumbers(number - 1, n);
    Console.Write($" {number}, ");
}

Console.Write($"\nM={m}; N={n} -> [");

int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

PrintNumbers(n, m);
Console.Write("]");

