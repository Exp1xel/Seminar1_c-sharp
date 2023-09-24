﻿/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//Доделано после дедлайна

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows,columns];
}

void Fill2dArray(int[,] array, int size)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                array[i,j] = ++count;
            }
            else if (i == 1)
            {
                if (j == array.GetLength(1) - 1)
                {
                    array[i,j] = ++count;
                }
                else
                {
                    array[i,j] = size - array.GetLength(1) + j;
                }
            }
            else if (i == 2)
            {
                if (j == array.GetLength(1) - 1)
                {
                    array[i,j] = ++count;
                }
                else if (j == 0)
                {
                    array[i,j] = size - count;
                }
                else 
                {
                    array[i,j] = size - (j-1);
                }
            }
            if (i == array.GetLength(0)-1)
            {
                //Console.WriteLine(k);
                array[i,array.GetLength(1)-1 - j] = ++count;
            }
        }
            
}

void Print2DArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

/*int rows = InputNum("Введите строки: ");
int columns = InputNum("Введите столбцы: ");*/
int rows = 4;
int columns = 4;
int size = rows * columns;
/*int min = InputNum("Введите минимальную границу: ");
int max = InputNum("Введите максимальную границу: ");*/

int[,] arr = Create2DArray(rows, columns);
Fill2dArray(arr, size);
Console.WriteLine("Двумерный массив: ");
Print2DArray(arr);
