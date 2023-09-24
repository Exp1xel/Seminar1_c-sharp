/*int inputMessageConv(string message){
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}


int number = inputMessageConv("Введите трехзначное число");
if (number <= 99 || number >= 1000){
    Console.WriteLine("Введено не трехзначное число");
    return;
}

Console.WriteLine((number / 10) % 10);*/
/*int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] FillArray(int length){
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputNum($"Введите {i+1}ое число");
    }
    return arr;
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int CheckPos(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}

int length = InputNum("Введите размер массива: ");
int[] array = FillArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во положительных чисел = {CheckPos(array)}");*/

double[] line1 = InputDataLine(1);
double[] line2 = InputDataLine(2);

if (CheckLines(line1, line2)){
    Console.WriteLine($"Точка пересечения прямых - {FindDot(line1, line2)[0]}, {FindDot(line1, line2)[1]}");
}

double[] InputDataLine(int num){
    double[] arr = new double[2];
    arr[0] = InputNum($"Введите коэффициент для прямой {num}");
    arr[1] = InputNum($"Введите константу для прямой {num}");

    return arr;
}

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

bool CheckLines(double[] arr1, double[] arr2){
    if (arr1[0] == arr2[0]){
        if (arr1[1] == arr2[1]){
            Console.WriteLine("Прямые совпадают.");
            return false;
        }
        else{
            Console.WriteLine("Прямые параллельны.");
            return false;
        }
    }
    return true;
}

double[] FindDot(double[] arr1, double[] arr2){
    double[] dotCoord = new double[2];
    dotCoord[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    dotCoord[1] = (line1[0] * dotCoord[0]) + line1[1];

    return dotCoord;
}