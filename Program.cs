// Задача 3: Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным

// 4 => да
// -3 => нет
// 7 => нет

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     System.Console.Write("Четное");
// }
// else
// {
//      System.Console.Write("Нечетное");

// }

// Задача 4. Напишите программу, которая на вход принимает число
// (N), а на выходе показывает все чётные числа от 1 до N.

// 5 => 2, 4
// 8 => 2, 4, 6, 8


System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        System.Console.Write(i + " ");
    }
    i ++;

}