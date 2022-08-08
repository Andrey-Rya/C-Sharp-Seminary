// проверяем четное это число или нет?
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = N % 2;
Console.WriteLine("***");
// проверяем условие на четность иначе на else
if (A == 0)
{
    Console.WriteLine("Да - это чётное число"); // % - показывает остаток от деления на 2
}
else
{
    Console.WriteLine("Нет = это нечётное число");
}

