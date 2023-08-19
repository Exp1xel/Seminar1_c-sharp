/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

try 
{
    Console.Write("Введите последовательно 3 числа через пробел или запятую без пробела ");
    //int[] input_numb = int.Parse(Console.ReadLine().Split(' '));
    string[] arr = Console.ReadLine()!.Split(' ', ',');
    int max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < int.Parse(arr[i])) max = int.Parse(arr[i]);
    }
    Console.WriteLine(max);   
}
catch 
{
    Console.WriteLine("Введенная последовательность не соответствует условию. Попробуйте заного...");
}
