﻿/* // ЗАДАЧА 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число для сравнения");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1 + " больше чем " + number2);
}
else
{
    Console.WriteLine(number2 + " больше чем " + number1);
}*/

/* // ЗАДАЧА 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа для сравнения");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int result = number1;
if (number2 > result)
{
    result = number2;
}
if (number3 > result)
{
    result = number3;
}
Console.WriteLine(result);*/

/* // ЗАДАЧА 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}*/

/* // ЗАДАЧА 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= num)
{
    if (index % 2 == 0)
    {
        Console.Write(index + ", "); 
    }
    index++;
}
*/

/* // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string num = Console.ReadLine();
Console.WriteLine(num[1]);*/

/* // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int length = num.Length;
if (length <= 2)
{
    Console.WriteLine("цифры нет");
}
else Console.WriteLine(num[2]); */

/* // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.Write("Понедельник");
if (num == 2) Console.Write("Вторник");
if (num == 3) Console.Write("Среда");
if (num == 4) Console.Write("Четверг");
if (num == 5) Console.Write("Пятница");
if (num == 6) Console.Write("Суббота");
if (num == 7) Console.Write("Воскресенье");
if (num <=5) Console.Write(", работаем :( ");
if (num >=6 ) Console.Write(", отдыхаем :) ");
*/

/* // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
if (num[0] == num[4])
{
    if (num[1] == num[3]) Console.WriteLine("да");
}
else Console.WriteLine("нет");*/

/*// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(int x, int y, int z, int x2, int y2, int z2)
{
    double dis = Math.Sqrt(((x - x2) * (x - x2)) + ((y - y2) * (y - y2)) + ((z - z2) * (z - z2)));
    return dis;
}
Console.WriteLine("Задайте координаты первой точки");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distance(x, y, z, x2, y2, z2));
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double Cube(int i)
{
    double cube = Math.Pow(i, 3);
    return cube;
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<n; i++)
{
    Console.Write($"{Cube(i)}, ");
}
Console.Write($"{Cube(n)}.");