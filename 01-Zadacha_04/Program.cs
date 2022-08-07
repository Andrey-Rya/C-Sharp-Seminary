// Программа на входе имеет 3 числа а на выходе выводит max из них
Console.WriteLine("Введите первое число: ");// вводим число А
int number1 = Convert.ToInt32(Console.ReadLine()); // запоминаем 1
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());// запоминаем 2
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());// запоминаем 3
int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write("max = ");
Console.WriteLine(max);
