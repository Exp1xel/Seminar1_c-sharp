/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int CountEven(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

int size = InputNum("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Кол-во четных чисел в массиве = {CountEven(array)}");