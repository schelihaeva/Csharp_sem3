// Напишите программу, ктороая принимает на вход число (N) и выдает таблицу квадратов числе от 1 до N
// 5-> 1,4,9,16,25
// 2->1,4

System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));// Math.Abs -сконвертировали отрицательное уисло в положительное
int i = 1;

while(i <= number) 
{
System.Console.Write($"{Math.Pow(i, 2)} ");
i++;
}

