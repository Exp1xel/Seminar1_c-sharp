int inputMessageConv(string message){
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

bool checkWeekday(int day){
    if (day < 1 || day > 7)
        return false;
    else 
        return true;
}

bool checkWeekend(int day){
    if (day == 6 || day == 7)
        return true;
    else 
        return false;
}

int number = inputMessageConv("Введите день недели");

if (checkWeekday(number) && checkWeekend(number))
    Console.WriteLine("Этот день является выходным");
else if (!checkWeekday(number))
    Console.WriteLine("Это число не является днем недели");
else if (!checkWeekend(number))
    Console.WriteLine("Этот день не является выходным");