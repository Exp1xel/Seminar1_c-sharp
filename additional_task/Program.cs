/*     -------------УСЛОВИЕ
Программа на вход получает натуральное число. Необходимо его преобразовать таким образом, чтобы все нечетные числа стояли впереди, а все четные позади. При этом внутри четных и нечетных чисел очередность должна сохраняться.
Результатом должно быть новое число, а не просто вывод на печать цифр в нужном порядке. Использовать можно только арифметические действия без работы со строкой.

Пример:
12345 -> 13524
3658563 -> 3553686
48 -> 48
5497 -> 5974*/

//      ------------Первоначальный способ, рабочий, но избыточный

/*Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int result = 0;
int count = 0;
int even = 0;
int count2 = 0;
for (int i = number; i > 0; i/=10){
    Console.WriteLine(i + " its i");
    if (i % 10 % 2 == 0)
    {
        continue;
    }
    else 
    {
        int j = i; 
        while (j % 10 % 2 != 0){
            count++;
            j /= 10;
        }
        if (j == 0) break;
        while (j % 10 % 2 == 0 && j != 0){
            even++;
            j /= 10;
        }
        i = (i / (int)Math.Pow(10,(count + even))*(int)Math.Pow(10,count) + i % (int)Math.Pow(10, count)) * (int)Math.Pow(10, even) + (i / (int)Math.Pow(10, count)) % (int)Math.Pow(10, even);

        result = result % (int)Math.Pow(10,(count2)) + i * (int)Math.Pow(10,(count2));
        count2++;
        count = 0;
        even = 0;
    }
}
if (count2 == 0)
    Console.WriteLine(number);
else
    Console.WriteLine(result);*/

//      ----------------Менее избыточный способ, окончательный вариант
Console.Write("Введите число ");

int number = int.Parse(Console.ReadLine()!);
int result = 0, step = 0, count = 0;

for (int i = number; i > 0; i/=10){
    // if (step == 0){
    //     result += i % 10;
    //     if (i % 10 % 2 == 0)
    //         count++;
    //     step++;
    //     continue;
    // }
    if (i % 10 % 2 == 0)
    {
        if (count != 0)
            result = result / (int)Math.Pow(10,(count)) * (int)Math.Pow(10,(count+1)) + (i % 10 * (int)Math.Pow(10,(count)) + result % (int)Math.Pow(10,(count)));
        else if (step == 0 && count == 0)
            result = (i % 10) + result;    
        else
            result = result * (int)Math.Pow(10,(count+1)) + i % 10;

        count++;
    }
    else 
        result = (i % 10) * (int)Math.Pow(10,(step)) + result;

    step++;
}
Console.WriteLine(result + " :end result");
