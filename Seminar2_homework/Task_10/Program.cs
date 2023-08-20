int inputMessageConv(string message){
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}


int number = inputMessageConv("Введите трехзначное число");
if (number <= 99 || number >= 1000){
    Console.WriteLine("Введено не трехзначное число");
    return;
}

Console.WriteLine((number / 10) % 10);