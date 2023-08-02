// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



Console.WriteLine("Введите координаты точек A и B в формате x,y,z:");
string[] aInput = Console.ReadLine().Split(',');
string[] bInput = Console.ReadLine().Split(',');

double ax = double.Parse(aInput[0]);
double ay = double.Parse(aInput[1]);
double az = double.Parse(aInput[2]);

double bx = double.Parse(bInput[0]);
double by = double.Parse(bInput[1]);
double bz = double.Parse(bInput[2]);

double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
Console.WriteLine($"Расстояние между точками: {distance:F2}");