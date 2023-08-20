Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine((number / 10) % 10);