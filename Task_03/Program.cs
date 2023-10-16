// // Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int[3];
 System.Console.Write("Введите координтату x точки А: ");
A[0] = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите координтату y точки A: ");
A[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координтату z точки A: ");
A[2] = Convert.ToInt32(Console.ReadLine());

int[] B = new int[3];
System.Console.Write("Введите координтату x точки B: ");
B[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координтату y точки B: ");
B[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координтату z точки B: ");
B[2] = Convert.ToInt32(Console.ReadLine());

 int pointA = (int)Math.Pow(A[0]-B[0],2);  // находим разницу, возводим значения в квадрат? (int)ставим,чтоб преобразовать значение в int
int pointB = (int)Math.Pow(A[1]-B[1],2); // находим разницу, возводим значения в квадрат
int pointC= (int)Math.Pow(A[2]-B[2],2);

double Lenght = Math.Sqrt(pointA+pointB+pointC); // находим квадратный корень
System.Console.WriteLine(Math.Round(Lenght, 2)); // с помощью Math.Round окургляем значение (3) - количество знаков после запятой