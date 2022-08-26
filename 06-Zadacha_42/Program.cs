// программа преобразует десятичное число в двоичное

//==== решение с помощью рекурсии ==== //
void PrintBinary(int N) // передали наше вводное число в метод
{
    if(N <= 0) return;
    PrintBinary(N/2); // проверяем условивие >0 и снова начинаем цикл
    Console.Write(N%2);
}
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);

//==== решение выводит лишние 5 нулей в конце?? ==== //
// void ReverseArray(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         temp = arr[i]; // записываем первый эл-т массива
//         arr[i] = arr[arr.Length - 1 - i];// записываем последний зл-т массива
//         arr[arr.Length - 1 - i] = temp; // в последний элемент записываем первый
//     }
// }

// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// int num = number;
// int count = 0;
// for (int i = 0; i <= num; i++)
// {
//     result = number % 2;
//     number = number / 2;
//     Console.Write(result);
//     count++;
//     if(number <= 0) break;
// }
// int[] arr = new int[count];
// for (int j = 0; j <= arr.Length - 1; j++)
// {
//     result = number % 2;
//     number = number / 2;
//     arr[j] = result;
//    //if(number <= 0) break; 
// }
// ReverseArray(arr);
// Console.WriteLine(string.Join(", ", arr));