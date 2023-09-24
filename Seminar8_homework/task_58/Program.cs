/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows,columns];
}

void Fill2dArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max+1);
}

int[,] Product2Matrices(int[,] array1, int[,] array2)
{
    int[,] product = new int[array1.GetLength(0),array2.GetLength(1)]; 
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            //Так как, чтобы произведение имело смысл кол-во столбцов 1ой и строк 2ой должны быть равны,
            //то кол-во итераций будет одинаковое и 
            //поэтому без разницы по какому массиву будет идти
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                product[i,j] += array1[i,k] * array2[k,j]; 
            }
        }
    return product;
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
 
bool CheckProductPossib(int[,] arr1, int[,] arr2)
{
    return arr1.GetLength(1) != arr2.GetLength(0);
}

//В условии ничего не сказано про границы,
//поэтому для простоты решения и проверки
//я использую одни и те же границы значений для обеих матриц

int min = InputNum("Введите минимальную границу: ");
int max = InputNum("Введите максимальную границу: ");

int[,] matrix1 = Create2DArray(InputNum("Введите кол-во строк для 1ой матрицы: "), InputNum("Введите кол-во столбцов для 1ой матрицы: "));
int[,] matrix2 = Create2DArray(InputNum("Введите кол-во строк для 2ой матрицы: "), InputNum("Введите кол-во столбцов для 2ой матрицы: "));

Fill2dArray(matrix1, min, max);
Fill2dArray(matrix2, min, max);

Console.WriteLine("Первая матрица: ");
Print2DArray(matrix1);
Console.WriteLine("Вторая матрица: ");
Print2DArray(matrix2);

if (CheckProductPossib(matrix1, matrix2))
{
    Console.WriteLine("Количество строк второй матрицы не равно кол-ву столбцов первой, поэтому произведение первой матрицы на вторую не имеет смысла. Попробуйте снова!");
}
else
{
    Console.WriteLine("Произведение двух матриц: ");
    Print2DArray(Product2Matrices(matrix1, matrix2));
}
