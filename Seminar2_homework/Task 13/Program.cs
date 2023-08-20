int inputMessageConv(string message){
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

int getNumberOfSteps (int number){
    int count = 0;
    for (int i = number; i > 0; i/=10){
        count++;
    }
    return count-3;
}

bool checkNumber(int number){
    if (getNumberOfSteps(number) <0)
        return true;
    else 
        return false;    
}

int number = inputMessageConv("Введите число ");

if ( checkNumber(number))
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(number / ((int)Math.Pow(10, getNumberOfSteps(number))) % 10);
