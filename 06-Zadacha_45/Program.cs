// программа создает копию заданного (у меня случайного) массива 
// с помощью поэлементного копирования

const int ARRAY_SIZE = 5; // вводим размер массива
const int LEFT_RANGE = -100;// вводим мин значение массива
const int RIGHT_RANGE = 100;// вводим макс значение массива

//=== заполняем массив рандомными числами ===//
int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[ARRAY_SIZE];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LEFT_RANGE, RIGHT_RANGE + 1);
    }
    return arr;
}
int[] FirstArray = FillArray(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.Write(" Случайный массив из 5-ти чисел: ");
Console.WriteLine('[' + string.Join(", ", FirstArray) + ']');
Console.WriteLine();

int ArraySize = 0;
int[] SecondArray = new int[ArraySize];
Console.Write(" Второй массив - копия первого:: ");
CopyArray(FirstArray, SecondArray);

//=== поэлементное копирование массива с выводом в консоль ===//
void CopyArray(int[] SecondArray, int[] FirstArray)
{
    for (int i = 0; i < FirstArray.Length-1; i++)
        FirstArray[i] = SecondArray[i];
    Console.WriteLine('[' + string.Join(", ", SecondArray) + ']');
}

/* === Второй вариант без использования массива случайных чисел === */
// int[] FirstArray = new int[] { 25, 32, 51, 79, 91 };
// Console.Write(" Случайный массив из 5-ти чисел: ");
// Console.WriteLine('[' + string.Join(", ", FirstArray) + ']');
// Console.WriteLine();
// int ArraySize = 0;
// int[] SecondArray = new int[ArraySize];
// Console.Write(" Второй массив - копия первого:: ");
// CopyArray(FirstArray, SecondArray);

// //=== поэлементное копирование массива с выводом в консоль ===//
// void CopyArray(int[] SecondArray, int[] FirstArray)
// {
//     for (int i = 0; i < FirstArray.Length - 1; i++)
//         FirstArray[i] = SecondArray[i];
//     Console.WriteLine('[' + string.Join(", ", SecondArray) + ']');
// }
