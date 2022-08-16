// Программа по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четв (X и Y) 
// решаем с помощью массивов

Console.WriteLine("Введите четверть: ");
int quater = Convert.ToInt32(Console.ReadLine()); 
string[] arr = {"x>0;y>0", "x<0;y>0", "x<0;y<0", "x>0;y<0"}; // записываем все условия в массив
if(quater >=1 && quater <=4) // если quater >=1 и <=4 то делаем ниже
{
    Console.WriteLine(arr[quater-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}
