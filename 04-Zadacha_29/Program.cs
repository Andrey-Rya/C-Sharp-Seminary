// программа задаёт массив из 8 элементов и выводит их на экран.
Console.Clear(); // очистка консоли
int N = 8; // задаем кол-во элементов массива
int[] Array = new int[N]; // создали массив из 8-ми симв
Console.WriteLine("Введите массив из 8 цифр: ");

for (int i = 0; i < N; i++) // цикл ввода массива с клавиатуры
{
	Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(); // просто пробел
Console.Write("Вы ввели этот массив: ");

for (int i = 0; i < N; i++) // вывод массива в терминал
{
	//Console.Write("{0}, ", Array[i]); //второй вариант вывода
	Console.Write('[' + string.Join(",", Array[i]) + ']');
}
