/*Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 == number2*number2){
    Console.WriteLine("Yes");
}
else {
    Console.WriteLine("No");
}*/

/*Console.Write("Введите номер дня недели: ");
int week_num = int.Parse(Console.ReadLine()!);
string[] weekDays = new[] {"Понедельник","Вторник","Среда","Четверг", "Пятница", "Суббота", "Воскресенье"};

for (int i = 1; i <= weekDays.Length; i++){
    if (week_num == i)
    {
        Console.WriteLine($"Наименование {week_num}го дня недели: {weekDays[i-1]}");
        break;
    }
} */


/*switch(week_num)
{
    case 1:  Console.WriteLine("Понедельник"); break;
    case 2:  Console.WriteLine("Вторник"); break;
    case 3:  Console.WriteLine("Среда"); break;
    case 4:  Console.WriteLine("Четверг"); break;
    case 5:  Console.WriteLine("Пятница"); break;
    case 6:  Console.WriteLine("Суббота"); break;
    case 7:  Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Такого дня недели нет"); break;
}*/

/*Console.WriteLine("Введите начальное число");
int input_num = int.Parse(Console.ReadLine()!);

for (int i = -input_num; i < input_num+1; i++){
    Console.Write($" {i}");
}*/

Console.WriteLine("Введите трехзначное число ");
int input_num = int.Parse(Console.ReadLine()!);

Console.Write(input_num % 10);