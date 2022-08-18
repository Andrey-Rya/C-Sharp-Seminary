// Программа принимает на вход координаты 2-х точек и находит 
// расстояние между ними в 3D  {A(3,6,8); B(2,1,-7) -> 15,84} {A(7,-5,0); B(1,-1,9) -> 11,53}

double[] A = new double[3];
double[] B = new double[3];

Console.WriteLine("Введите число x1: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y1: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z1: ");
A[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число x2: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2: ");
B[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z2: ");
B[2] = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2));
Console.WriteLine($"расстояние между точками в 3D = {length}");
