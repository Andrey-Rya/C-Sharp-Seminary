// программа принимает на вход число А и выдает 
// сумму чисел от 1 до А (7->28, 4->10, 8->36)

Console.Write("Ввод числа А: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
	sum = sum + i;
}
Console.Write($"Результат работы программы = {sum}");
