﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.

Console.Write("Введите элементы(через пробел): ");
string y = Console.ReadLine();
int[] arr = Array.ConvertAll(y.Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Количествово элементов > 0 = {count}");