// напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// А(3,6); В(2,1)->5,09
// A(7,-5); B(1,-1)->7,21



int[] A = new int[2];
System.Console.Write("Введите координтату x точки А: ");
A[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координтату y точки A: ");
A[1] = Convert.ToInt32(Console.ReadLine());
int[] B = new int[2];
System.Console.Write("Введите координтату x точки B: ");
B[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координтату y точки B: ");
B[1] = Convert.ToInt32(Console.ReadLine());
int res1 = (int)Math.Pow(A[0]-B[0],2);  // находим разницу, возводим значения в квадрат? (int)ставим,чтоб преобразовать значение в int
int res2 = (int)Math.Pow(A[1]-B[1],2); // находим разницу, возводим значения в квадрат
double dist = Math.Sqrt(res1+res2); // находим квадратный корень
System.Console.WriteLine(Math.Round(dist, 3)); // с помощью Math.Round окургляем значение (3) - количество знаков после запятой