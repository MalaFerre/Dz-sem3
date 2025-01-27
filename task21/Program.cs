﻿// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.Write("Введите координаты Х точки А: ");
int[] coordsA = new int[3];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Y точки A: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Z точки А: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаты Х точки B: ");
int[] coordsB = new int[3];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Y точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Z точки B: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координаты Х точки C: ");
// int[] coordsC = new int[3];
// coordsC[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координаты Y точки C: ");
// coordsC[1] = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координаты Z точки C: ");
// coordsC[2] = Convert.ToInt32(Console.ReadLine());

double distanceX = Math.Pow(coordsB[0] - coordsA[0], 2 );
double distanceY = Math.Pow(coordsB[1] - coordsA[1], 2);
double distanceZ = Math.Pow(coordsB[2] - coordsA[2], 2);
double Result = Math.Sqrt(distanceX + distanceY + distanceZ);

System.Console.WriteLine(Math.Round(Math.Sqrt(Result),2));