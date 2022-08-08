// программа принимает на вход одно число (N)
// а на выходе показывает целые все целые числа от -N до N

Console.WriteLine("Введите целое число: ");// вводим число N
int N = Convert.ToInt32(Console.ReadLine()); // запоминаем число N
int count = -N; // присваиваем началу счетчика старт от минус N

//запускаем цикл для неотрицательного числа
/*while(count <= N)
{
    Console.WriteLine(count);
    count++;
}
*/

//-----------Для любого целого числа-----------------------
if (count < N) //если счетчик <N делай ниже. Иначе на else
{
    while (count <= N) // до тех пор пока count<=N делай ниже
    {
        Console.WriteLine(count);
        count++;
    }
}
else
{
    while (count >= N)
    {
        Console.WriteLine(N);
        N++;
    }
}
