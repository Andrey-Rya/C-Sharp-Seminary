// Задайте значение M и N. Напишите программу, которая выведет сумму натуральных чисел
// в промежутке от M до N с помощью рекурсии

Console.Clear();
int m = InputNum("Введите M: "); // 1
int n = InputNum("Введите N: "); // 2
int sum = 0;
void PrintNumbers(int M, int N, int sum)
{
    if (M > N)
    {
        Console.Write($"{sum}"); 
        return;
    }
    sum = sum + (M++);
    PrintNumbers(M, N, sum);  
}
Console.Write($"\nСумма всех чисел от {m} до {n} = [");
int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
PrintNumbers(m, n, sum);
Console.Write("]");
