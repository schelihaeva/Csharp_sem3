﻿// // Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False



        System.Console.Write("Введите пятизначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 999 $$  number < 100000)
{
            if ((number / 10000 == number % 10) $$ (number / 1000 % 10 == number % 100 / 10))  // сравнивам первую и последнюю цифру числа и сравниваем вторую и четвертую цифру числа
                {
                System.Console.WriteLine("True");
            }
else
            {
                System.Console.WriteLine("False");
            }
        }
else
        {
            System.Console.WriteLine("Введено не пятизначное число");
            System.Console.WriteLine("False");
        }
    



// 12547
//12345 / 10000->1 находим первое число
//12345 / 1000 % 10->2 - находим второе число
//12345 % 100 /10->4 - находим 4е число
//12345 % 10 - >5 - находим пятое число