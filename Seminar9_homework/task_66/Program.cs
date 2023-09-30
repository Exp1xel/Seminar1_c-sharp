/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int ShowSum (int start, int end)
{
    return start == end ? start : start + ShowSum(++start, end);
}
int M = InputNum("Введите M: ");
int N = InputNum("Введите N: ");
Console.WriteLine(
    M > N ? ShowSum(N,M) 
        : ShowSum(M,N)
);