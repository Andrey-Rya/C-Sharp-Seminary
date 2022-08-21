// цикл принимает на вход 2 числа (А и В) и возводит число А в 
// натуральную степень В
Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int Exp(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
int degree = Exp(a, b);
Console.WriteLine($"Число {a} в степени {b} = " + degree);
