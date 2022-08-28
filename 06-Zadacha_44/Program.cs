// не используя рекурсию, выведите первые N чисел Фибоначчи. 
// первые два числа Фибоначчи: 0 и 1.
// если N = 5 -> 0 1 1 2 3
// если N = 7 -> 0 1 1 2 3 5 8
// если N = 3 -> 0 1 1
Console.WriteLine("Какое количество чисел Фибоначчи необходимо показать?  ");
int N = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
int n2 = 1;
Console.Write($"Первые {N} чис Фибоначчи  -> {n1 } {n2 }");

for (int i = 3; i <= N; i++)
{
    int summ = n1 + n2;
    Console.Write($" {summ}");
    n1 = n2;
    n2 = summ; 
}
