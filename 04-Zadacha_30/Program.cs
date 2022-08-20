// программа выводит массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.[1,0,1,1,0,1,0,0]
 
Console.Clear();
int N = 8; // задаем кол-во элементов массива
int min = 0; // задали нулевой элемент
int max = 1; // задали элемент 1
int [] Array(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
Console.WriteLine();
Console.WriteLine('[' + string.Join(", ", Array(N,min,max))+']');// разделили строку и  вывели массив

// ниже просто вывод 8-ми случайных чисел цифрами 0 и 1
 
// for (int i = 0; i <= 7; i++)
//     {
//         int rnd = new Random().Next(0, 2);
//         Console.Write($"{rnd},");
//     }
