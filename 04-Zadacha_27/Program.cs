// программа принимает на вход число и 
// показывает сумму цифр в этом числе
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (a >= 0) // находим сумму чисел >=0
{
	while (a > 0)
	{
		int number = a % 10;
		a = a / 10;
		result = result + number;
	}
	Console.WriteLine($"Сумма всех положительных цифр в вашем числе: {result}");
}
else // находим сумму чисел < 0
{
	string someStr = a.ToString();
	string ss = Convert.ToString(someStr[1]);
	int num1 = int.Parse(ss);
	while (a < 0)
	{
		int number = a % 10;
		a = a / 10;
		result = result - number;
	}
	result = result - num1 - num1;
	Console.WriteLine($"Сумма всех цифр с учетом первого отрицательного числа = {result}");
}
