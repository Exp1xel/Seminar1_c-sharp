/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void ShowNum(int N)
{
    if (N < 1) return;
    Console.Write($"{N} ");
    ShowNum(--N);
}
ShowNum(InputNum("Введите N: "));