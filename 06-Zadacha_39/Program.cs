// программа переворачивает все элементы массива 
// меняя первый элемент на последний и тд

const int ARRAY_SIZE = 5; // размер массива (менять в программе нельзя)
const int LEFT_RANGE =-10;
const int RIGHT_RANGE = 10;

//=== заполняем массив рандомными числами ===//
int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int [] arr = new int [ARRAY_SIZE];
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = rand.Next(LEFT_RANGE, RIGHT_RANGE +1);  
    }
    return arr;
}

//=== меняем элементы зеркально относительно середины ===//
void ReverseArray(int [] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
       temp = arr[i]; // записываем первый эл-т массива
       arr[i] = arr[arr.Length - 1 - i];// записываем последний зл-т массива
       arr[arr.Length - 1 - i] = temp; // в последний элемент записываем первый
    }
}

int[] array = FillArray(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) +']');
ReverseArray(array);
Console.WriteLine('[' + string.Join(", ", array) + ']');
