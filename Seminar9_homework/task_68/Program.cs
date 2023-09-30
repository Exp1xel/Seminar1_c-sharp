/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int InputNum (string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int fAccerman(int n, int m)
{
    if (n == 0) return m+1;
    else if (m == 0) return fAccerman(n-1, 1);
    else return fAccerman(n-1, fAccerman(n, m-1));
}

int m = InputNum("Введите первое неотрицательное число m");
int n = InputNum("Введите второе неотрицательное число n");

Console.WriteLine($"A(m,n) = {fAccerman(m,n)}");