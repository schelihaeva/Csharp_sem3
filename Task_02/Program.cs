// Напишите программу, ктороая принимает на вход число (N) и выдает таблицу квадратов числе от 1 до N
// 5-> 1,4,9,16,25
// 2->1,4

 //1 вариант решения

// System.Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); //Math.Abs - преобразуем число в целое положительное число
// int i = 1;
// while(i<= number)
// {
//     System.Console.WriteLine($"{Math.Pow(i, 2)} ");
//     i++;
// }

// 2 вариант решения
System.Console.WriteLine("Введите число: ");
 int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

 for(int i = 1; i <= number; i++)
 {
    System.Console.WriteLine($"{Math.Pow(i, 2)} ");
 }