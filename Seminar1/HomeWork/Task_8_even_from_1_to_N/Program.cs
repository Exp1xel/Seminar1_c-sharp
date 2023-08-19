/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число");
int input_numb = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= input_numb; i++)
{
    if (i % 2 == 0)
    {
        if (i == input_numb || i == input_numb - 1)
        {
            Console.Write(i);
            break;
        }
        Console.Write(i + ", ");
    }
}