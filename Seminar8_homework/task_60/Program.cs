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
//поэтому к сдаче сделал просто со случайными двузначными числами. Возможно все же успею доделать и залить на гитхаб до проверки,
//но если так, то это уже будет после дедлайна на сайте, не знаю как это будет оцениваться
int[] CreatePool(int poolSize)
{
    int[] array = new int[90];
    int[] pool = new int[poolSize];
    int temp;
    int randomNum;
    var rand = new Random();
    int i;

    //Заполняем массив всеми двузначными числами
    for (i = 0; i < array.Length; i++)
        array[i] = i+10;
    //Перемешиваем его
    for (i = array.Length-1; i > 0; i--)
    {
        randomNum = rand.Next(i+1);
        temp = array[randomNum];
        array[randomNum] = array[i];
        array[i] = temp;
    }
    for (i = 0; i < pool.Length; i++)
        pool[i] = array[i];

    /*PrintArray(array);
    PrintArray(pull);*/
    return pool;
}
void Fill3DArray(int[,,] array, int[] pool)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = pool[count++];
            }
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine("Полученный трехмерный массив построчно: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
        Console.WriteLine();
    }
    
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
bool CheckSize(int x, int y, int z)
{
    return x * y * z > 90;
}

int x = InputNum("Введите количество строк трехмерного массива: ");
int y = InputNum("Введите количество столбцов трехмерного массива: ");
int z = InputNum("Введите количество слоев трехмерного массива: ");
int[,,] myArray = Create3DArray(x, y, z);

if (CheckSize(x,y,z)){
    Console.WriteLine($"Размер вашего массива: {x*y*z}. Несоответствие условию, так как кол-во неповторяющихся двузначных чисел: 90. Попробуйте снова!");
}
else
{
    Fill3DArray(myArray, CreatePool(x*y*z));
    Print3DArray(myArray);
}
