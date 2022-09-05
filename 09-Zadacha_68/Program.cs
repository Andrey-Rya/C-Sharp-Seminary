// программа вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9


Console.Clear();
Found:
int m = InputNum("Введите m= "); 
int n = InputNum("Введите n= "); 

int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

if (n > 3 || m > 3 || n < 0 || m < 0) 
{
    Console.WriteLine("\nПостарайтесь вводить значения от 0 до 3");
    goto Found;
}

// === вычисляем функцию Аккермана === //
int Ackermann(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Ackermann(M - 1, 1);
    if (M > 0 && N > 0) return Ackermann(M - 1, Ackermann(M, N - 1));
    return Ackermann(M, N);
}

Console.WriteLine($"Функция Аккермана для числа A({m},{n}) = {Ackermann(m, n)}");

