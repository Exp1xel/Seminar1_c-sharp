/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(double[] arr, int min, int max){

    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(new Random().NextDouble() * new Random().Next(min, max), 2);
}

void PrintArray(double[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();
}

double Difference(double[] arr){
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    return max - min;
}

int size = InputNum("Введите размер массива: ");
int minimun = InputNum("Введите минимальную границу значений массива: ");
int maximum = InputNum("Введите максимальную границу значений массива: ");
double[] array = new double[size];
FillArray(array, minimun, maximum);
PrintArray(array);
Console.WriteLine($"Раница между максимальным и минимальным значением = {Difference(array)}");
