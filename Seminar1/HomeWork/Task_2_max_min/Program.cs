/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое целое число ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число ");
int numb2 = int.Parse(Console.ReadLine()!);

if (numb1 > numb2)
    Console.WriteLine($"Большее число {numb1}, а меньшее {numb2}");
else  
    Console.WriteLine($"Большее число {numb2}, а меньшее {numb1}");
