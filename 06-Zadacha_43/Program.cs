// программа находит точку пересечения двух прямых, заданных
// уравнениями y=k1*x+b1, y=k2*x+b2. 
// значения b1, k1, b2 и k2 задаются пользователем
// формула y=k1*x+b1=k2*x+b2, откуда можно найти Х и Y
Console.Clear();
void result(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine();
    if (k1 == k2 && b1 != b2) Console.Write("Эти прямые параллельны!");
    else if (k1 == k2 && b1 == b2) Console.Write("Эти прямые совпадают!");
    else
        Console.Write($"Точка пересечения двух прямых -> ({x}; {y})");
}
Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
result(k1, b1, k2, b2);
