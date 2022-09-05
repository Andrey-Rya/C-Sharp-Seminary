// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N с помощью рекурсии
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number)
{
    if(number == 0)
    {
        return;
    }
    //Console.Write($"{number} "); // если оставим вывод здесь, то выведем обратную последовательность чисел от больш к меньш
    PrintNumbers(number-1);
    Console.Write($"{number} ");
}

PrintNumbers(n);


