// проверка 3-х чисел с проверкой на существование треугольника
// с такими сторонами (каждая сторона должна быть меньше суммы 
// двух других сторон)

/*Вводим числа для проверки*/
// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a);
// if (a + b > c && a + c > b && b + c > a)
// {
//     Console.WriteLine("Да! Треугольник существует.");
// }
// else
// {
//     Console.WriteLine("Нет! Треугольник не существует.");
// }

//=== второй вариант решения программы ===//
int Treg(double a, double b, double c)
{
    int result = 0;
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Да! Треугольник существует.");
        result = 1;
    }
    else
    {
        Console.WriteLine("Нет! Треугольник не существует.");
        result = 0;
    }
    return result;
};
Console.Write("Введите длину отрезка А: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите длину отрезка B: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите длину отрезка C: ");
double c = Convert.ToDouble(Console.ReadLine());

if (Treg(a, b, c) == 0)
{
    Console.Write("Треугольник НЕ существует");
}
else
{
    Console.Write("Треугольник существует");
}
