/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//Доделано после дедлайна
//Алгоритм рабочий, но только для 4х4, я старался более универсально придумать, но пока только в таком виде

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows,columns];
}
/*void FillLine(int start, int end, int x, int y, int count, int[,] array)
{
    while (start <= end-1)
    {
        array[x,y] = count++;
        start++;
    }
}*/
void Fill2dArray(int[,] array, int size)
{
    int count = 1;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int j = 0;
    int i = 0;

    while (j <= columns-1)
    {
        array[i,j] = count++;
        j++;
    }
    //FillLine(j, columns, i, j, count, array);
    i++;
    j--;
    while (i <= rows-1)
    {
        array[i,j] = count++;
        i++;
    }
    j = 0;
    i = 0;
    rows--;
    columns--;
    while (j <= columns-1)
    {
        array[rows-i,columns-1-j] = count++;
        j++;
    }
    i = 0;
    j = 0;
    rows--;
    columns--;
    while (i <= rows-1)
    {
        array[rows-i,j] = count++;
        i++;
    }
    i = 0;
    j = 0;
    while (j <= columns-1)
    {
        array[rows-1,columns-1+j] = count++;
        j++;
    }
    i = 0;
    j = 0;
    rows--;
    while (i <= rows-1)
    {
        array[rows+1+i,columns] = count++;
        i++;
    }
    i = 0;
    j = 0;
    columns--;
    while (j <= columns-1)
    {
        array[rows+1+i,columns] = count++;
        j++;
    }

    /*i = array.GetLength(0)-1;
    while ( j >= 0) 
    {
        array[i,j] = count++;
        j--;
    }
    i--;
    j = 0;
    while (i >= 1)
    {
        array[i,j] = count++;
        i--;
    } 
    j++;
    i++;
    while (j <= columns-1)
    {
        array[i,j] = count++;
        j++;
    }
    i++;
    j--;
    while (i <= 3)*/



    // for (int i = 0; i < rows; i++)
    //     for (int j = 0; j < columns; j++)
    //     {
    //         if (i == 0)
    //         {
    //             array[i,j] = count++;
    //         }
            
    //         if (i == rows-1 && j == columns-1 && count != size)
    //         {
    //             /*columns--;
    //             rows--;*/
    //             j--;
    //             Console.WriteLine(count);
    //             while (j >= 0)
    //             {
    //                 array[i,j] = count++;
    //                 j--;
    //             }
    //             //array[i,j] = 1;
    //         }
    //         else if (j+1 == array.GetLength(1) && i != 0)
    //         {
    //             array[i,array.GetLength(1)-1] = count++;
    //         }
    //         /*if (i == 0)
    //         {
    //             array[i,j] = j+1;
    //         }
    //         else if (i == 1)
    //         {
    //             if (j == array.GetLength(1) - 1)
    //             {
    //                 array[i,j] = j+i+1;
    //             }
    //             else
    //             {
    //                 array[i,j] = size - array.GetLength(1) + j;
    //             }
    //         }
    //         else if (i == 2)
    //         {
    //             if (j == array.GetLength(1) - 1)
    //             {
    //                 array[i,j] = j+i+1;
    //             }
    //             else if (j == 0)
    //             {
    //                 array[i,j] = size - i*2 - 1;
    //             }
    //             else 
    //             {
    //                 array[i,j] = size - (j-1);
    //             }
    //         }
    //         if (i == array.GetLength(0)-1)
    //         {
    //             //Console.WriteLine(k);
    //             //array[i,array.GetLength(1)-1 - j] = j+i+1;
    //             array[i,j] = size - (i+j+1) -2;
    //         }*/
    //         //array[i,j] = count++;
    //     }
        
            
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

int rows = 4;
int columns = 4;
int size = rows * columns;

int[,] arr = Create2DArray(rows, columns);
Fill2dArray(arr, size);
Console.WriteLine("Двумерный массив: ");
Print2DArray(arr);
