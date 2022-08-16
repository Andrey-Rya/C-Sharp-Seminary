// Программа принимает на вход координаты 2-х точек и находит 
// расстояние между ними в 2D  {A(3,6); B(2,1) -> 5,09} {A(7,-5); B(1,-1) -> 7,21}
Console.WriteLine("Введите число x1: ");
double x1 = Convert.ToDouble(Console.ReadLine()); // double позволяет записывать дробные числа - напр 2,5
Console.WriteLine("Введите число y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));// Math.Pow-возведение в степень (х2-х1)*(х2-х1)
// double length = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1) * (y2 - y1)));// формула для вычисления расстояния между точками
Console.WriteLine($"расстояние между точками = {length}");


