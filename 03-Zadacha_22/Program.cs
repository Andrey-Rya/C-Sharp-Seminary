// Программа принимает на вход число (N) от 1 до N
Console.WriteLine("Введите любое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count >=1 && count <= N)
{
    Console.WriteLine(Math.Pow((count), 2));
    count++;
}

