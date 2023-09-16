/*int inputMessageConv(string message){
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
    Console.WriteLine("Этот день не является выходным");*/

/*int inputMessageConv(string message) {
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Power(int a, int b){
    int begin = 1;
    for (int i = 0; i < b; i++){
        begin *= a;
    }
    return begin;
}

bool ValidateExp(int b){
    if (b < 0){
        Console.WriteLine("Степень не является положительной или 0");
        return false;
    }
    return true;
}

int number = inputMessageConv("Введите основание: ");
//Console.WriteLine(number);
int exp = inputMessageConv("Введите степень: ");
//Console.WriteLine(exp);

if (ValidateExp(exp)){
    Console.Write($"Возведение в степень {exp} числа {number} равно ");
    Console.Write(Power(number, exp));
}*/

/*int inputMessageConv(string message) {
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int DigitSum(int number){
    int result = 0; 
    while (number > 0){
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = inputMessageConv("Введите число ");
Console.WriteLine($"Сумма цифр числа {number} = {DigitSum(number)} ");*/

/*int inputMessageConv(string message) {
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int [] CreateArray(int length, int begin, int end){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++){
        array[i] = random.Next(begin, end+1);
    }
    return array;
}

void ArrayPrint(int[] array ){
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int length = inputMessageConv("Введите длину массива: ");
int begin = inputMessageConv("Введите начало диапазона рандомной выборки: ");
int end = inputMessageConv("Введите конец диапазона рандомной выборки: ");
ArrayPrint(CreateArray(length, begin, end));*/
/*int Function1 (string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size){
    return new int[size];
}

void FillArray(int[] arr, int minValue, int maxValue){
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(minValue, maxValue+1);
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

void SumPosNegElements(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumPos += arr[i];
        else 
            sumNeg += arr[i];
    }
    Console.WriteLine($"SumPos = {sumPos}");
    Console.WriteLine($"SumNeg = {sumNeg}");
}

int size = Function1("Input size: ");
int min = Function1("Input min ");
int max = Function1("Input max ");

int[] array = CreateArray(size);
FillArray(array, min, max);
PrintArray(array);
SumPosNegElements(array);*/

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int[] Scalar(int[] array){
    int size = array.Length/2 + array.Length % 2;
    int[] newArray = new int[size]; 

    for (int i = 0; i < array.Length/2; i++)
        newArray[i] = array[i] * array[array.Length - 1 - i];

    if (array.Length % 2 == 1)
        newArray[size-1] = array[array.Length/2];
    
    return newArray;
}

int size = InputNum("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
PrintArray(array);
PrintArray(Scalar(array));
