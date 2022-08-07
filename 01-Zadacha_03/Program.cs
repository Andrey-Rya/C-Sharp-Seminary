// программа выдаёт название дня недели по заданному номеру
Console.WriteLine("Введите номер дня недели (от 1 до 7): ");// вводим № дня недели
int number_ned = Convert.ToInt32(Console.ReadLine()); // запоминаем № дня недели
if (number_ned == 1)
{
    Console.WriteLine("Monday");
}
if (number_ned == 2)
{
    Console.WriteLine("Tuesday");
}
if (number_ned == 3)
{
    Console.WriteLine("Wednesday");
}
if (number_ned == 4)
{
    Console.WriteLine("Thursday");
}
if (number_ned == 5)
{
    Console.WriteLine("Friday");
}
if (number_ned == 6)
{
    Console.WriteLine("Saturday");
}
if (number_ned == 7)
{
    Console.WriteLine("Sunday");
}
else if (number_ned > 7)
{
    Console.WriteLine("Нет такого номера в неделе");
}

// другой вариант решения вывода дня недели по заданному номеру
// Console.WriteLine("Введите номер дня недели (от 1 до 7): ");// вводим № дня недели
//int number = Convert.ToInt32(Console.ReadLine()); // запоминаем № дня недели

//switch (number)
//{
  //  case 1:
  //    Console.WriteLine("Понедельник");
  //    break;
  //  case 2:
  //    Console.WriteLine("Вторник");
  //    break;
  //  case 3:
  //    Console.WriteLine("Среда");
  //    break;
  //  case 4:
  //    Console.WriteLine("Четверг");
  //    break;
  //  case 5:
  //    Console.WriteLine("Пятница");
  //    break;
  //  case 6:
  //    Console.WriteLine("Суббота");
  //    break;
  //  case 7:
  //    Console.WriteLine("Воскресенье");
  //    break;
  //  default:
  //    Console.WriteLine("Нет такого дня");
  //    break;
//}