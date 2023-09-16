/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] arr, int min, int max){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int SumNotEven(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

int size = InputNum("Введите размер массива: ");
int minimun = InputNum("Введите минимальную границу значений массива: ");
int maximum = InputNum("Введите максимальную границу значений массива: ");
int[] array = new int[size];
FillArray(array, minimun, maximum);
PrintArray(array);
Console.WriteLine($"Сумма значений на нечетных позициях = {SumNotEven(array)}");