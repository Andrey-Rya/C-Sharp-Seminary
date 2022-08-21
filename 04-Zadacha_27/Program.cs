// программа принимает на вход число и 
// показывает сумму цифр в этом числе
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (a >= 0)
{
	while (a > 0)
	{
		int number = a % 10;
		a = a / 10;
		result = result + number;
	}
	Console.WriteLine($"Сумма всех цифр в вашем числе: {result}");
}
else
{
    int someValue = a;
    string someStr = someValue.ToString();
	int ss = Convert.ToInt32 (someStr[1]);
    Console.WriteLine($"строка a =  {a}");
    Console.WriteLine($"someStr[1] =  {someStr[1]}");
    Console.WriteLine($"s =  {ss}");
    while (a < 0)
    {
    	int number = a % 10;
    	a = a / 10;
    	result = result - number;
	// Console.WriteLine($"Сумма NUMBER в вашем числе: {number}");
    // Console.WriteLine($"Сумма A в вашем числе: {a}");
    // Console.WriteLine($"Сумма RESULT в вашем числе: {Math.Abs(result)}");
    }
    //result = result - s;
    int s = Convert.ToInt32(result-someStr[1]);
	Console.WriteLine($"Сумма RESULT-someStr[1] = {result} - {someStr[1]}");
    //int sum = new Int32 {someStr[1]} + {result};
	Console.WriteLine($"Сумма с учетом отр числа = {s}");
}

//int res = result - sum;
//Console.WriteLine($"Сумма всех цифр в нашем числе:  {res}"); // это второй вариант отображения
