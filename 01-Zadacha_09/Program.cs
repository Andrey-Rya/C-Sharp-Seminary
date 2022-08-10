// программа выводит случайное число от 10 до 99 и показывает максимальную цифру числа
int number = new Random().Next(10, 100); // получаем случ число от 10 до 99
Console.WriteLine($"Наше случайное число = {number}"); // знак $ позволяет отыскивать переменную в строке
int digit1 = number / 10; // определяем первое число
int digit2 = number % 10; // определяем второе число
if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}
