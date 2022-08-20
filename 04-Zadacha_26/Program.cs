// программа принимает на вход число и выдает количество цифр в нём

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while (number >0)
// {
//     number = number / 10;
//     i += 1;
// }
// if(number == 0)
// {
//   i +=1; // это условие работы при вводе 0
// }
// Console.WriteLine(i);

// решаем задачу через цикл

Console.Write("Введите число: ");
int cycle(int number)
{
    int sum = 0;
    if (number == 0)
    {
        sum += 1; // это условие работы при вводе 0
    }
    while (number > 0)
    {
	number = number / 10;
    sum += 1;
    }
    return sum;
}
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Количество цифр в вашем числе = {cycle(number)}");
