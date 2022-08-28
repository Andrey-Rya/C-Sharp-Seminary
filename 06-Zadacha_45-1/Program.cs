// программа принимает на вход число N и выдаёт произведение
// чисел от 1 до N. (использовать рекурсию)

Console.Clear();
Console.Write("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
double Result(int n) 
{
    // 5 = 1*2*3*4*5 = 120
    // 4 = 1*2*3*4 = 24
    // 3 = 1*2*3 = 6
    if (n == 1) return 1;
    else return n * Result(n-1);
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {Result(number)}");
