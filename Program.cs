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


// System.Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= N)
// {
//     if (i % 2 == 0)
//     {
//         System.Console.Write(i + " ");
//     }
//     i ++;

// }


// второй способ

//  for (int i = 2; i <= N; i +=2)
//  {
//     System.Console.Write(i + " ");
//  }


// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.

// Примеры
// a = 256 => 26
// a = 891 => 81\

// using System.Runtime.InteropServices;

// System.Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // ------100-----999--->

// if(number > 99 && number < 1000)
// {
//    int leftDigit = number / 100;
//    int rihgtDigit = number % 10;
//    int newNumber = leftDigit * 10 + rigtDigit;
//    System.Console.Write(newNumber); 
// }
// else
// {
//     System.Console.Write("Вы ввели не трехзначное число!");
// }



// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


// System.Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99 && number < 1000)
// {
//     int middleDigit = number / 10 % 10;
//     int rihgtDigit = number % 10;
//     int result = 1;
//     while(rihgtDigit > 0)
//     {
//         result *= middleDigit; // result = result * middleDigit;
//         rihgtDigit --;
    
//     }
//     System.Console.Write(result);
// }