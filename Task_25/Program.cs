﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow(ЗАПРЕЩЕНО)

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int a = Convert.ToInt32(Console.ReadLine());
double c = 1;
for (int i = 1; i <= a; i++)
    c = c * n;

Console.WriteLine($"Число {n} в степени {a} равно {c} ");

Console.WriteLine();

double b = Math.Pow(n, a); // Для проверки
Console.WriteLine($"Проверка {n} в степени {a} равно {b} ");