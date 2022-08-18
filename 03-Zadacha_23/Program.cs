// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите любое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // просто разьединил строку ))
for (int count = 1; count <= N; count++)
{
	Console.WriteLine(Math.Pow((count), 3));
}
