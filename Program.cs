﻿// Задача 3: Напишите программу, которая на вход принимает число и
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



// Задание 3. 

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.

// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1


// System.Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введит второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if( number1 % number2 == 0)
// {
//     System.Console.Write("Да");
// }
// else
// {
//     int number3 = number1 % number2;
//     System.Console.Write("Нет, " + number3 );
// }




// Задание 4.
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет



// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99)
// {
// System.Console.Write(number % 1000 / 100);
// }
// else
// {
//     System.Console.Write("Третьей цифры нет");
// }


// Задание 4*
// Напишите программу, которая выводит третью с
// начала цифру заданного числа
// 456 => 6
// 7812 => 1
// 9121 => 2  

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//     while (number > 999)
//     {
//         number /= 10; //number = number /10;
//     }
//     System.Console.Write(number % 10); 

// }
