// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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
}