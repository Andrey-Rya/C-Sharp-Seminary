// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1 с помощью рекурсии

Console.Clear();
int n = InputNum("Введите N: ");

void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    Console.Write($" {number}, ");
    PrintNumbers(number - 1);
    
}

Console.Write($"\nN={n} -> [");

int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

PrintNumbers(n);
Console.Write("]");
