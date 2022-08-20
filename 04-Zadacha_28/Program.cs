// программа принимает на вход число N и выдаёт произведение 
// чисел от 1 до N
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= n; i += 1)
{
    sum = sum * i;
}
Console.WriteLine(sum);
