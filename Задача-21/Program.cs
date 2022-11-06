/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */



Console.WriteLine("Введите Х точки A: ");
int x1 = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите Y точки A: ");
int y1 = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите Z точки A: ");
int z1 = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите Х точки B: ");
int x2 = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите Y точки B: ");
int y2 = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите Z точки B: ");
int z2 = int.Parse(Console.ReadLine()??"");

int sqrLenghtX = (x2 - x1) * (x2 - x1);
int sqrLenghtY = (y2 - y1) * (y2 - y1);
int sqrLenghtZ = (z2 - z1) * (z2 - z1);

double distance = Math.Sqrt(sqrLenghtX + sqrLenghtY + sqrLenghtZ);
System.Console.WriteLine("Расстояние равно " + distance);


int ReadLine(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ??"");
}
