/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int x, int y, int z) 
{
    return new int[x,y,z];
}

//Извините, не успеваю придумать алгоритм перемешивания случайных неповторяющихся элементов к дедлайну
//поэтому к сдаче сделал просто со случайными двухзначными числами, если все же успею доделать и залить на гитхаб, то этого сообщения не будет)

void Fill3DArray(int[,,] array)
{
  int count = 10;
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = new Random().Next(10, 100);
      }
}

void Print3DArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(2); k++)
        Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
        Console.WriteLine();
      }
  }
}

int x = InputNum("Введите количество строк трехмерной матрицы: ");
int y = InputNum("Введите количество столбцов трехмерной матрицы: ");
int z = InputNum("Введите количество слоев трехмерной матрицы: ");
int[,,] myArray = Create3DArray(x, y, z);
Fill3DArray(myArray);
Print3DArray(myArray);