// программа принимает на вход число А и выдает 
// сумму чисел от 1 до А (7->28, 4->10, 8->36)
// ИСПОЛЬЗУЕМ ФУНКЦИЮ
int cycle(int a)
{
  int sum = 0;
    for (int i = 1; i <= a; i++)
    {
	sum = sum + i;
    } 
    return sum; 
}

Console.Write("Ввод числа А: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = cycle(number); // запоминаем значение sum 
Console.Write($"Результат работы программы = {sum}");
// Console.Write($"Результат работы программы = {cycle(number)}"); второй вариант вывода
