// программа принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine($"Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N>=100 & N<1000)
{
    int N1 = N / 10;
    int N2 = N1 % 10;
    Console.WriteLine(N2);
      
}
else
{
    Console.WriteLine($"Ошибка! Повторите ввод!");
}
    


