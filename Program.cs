// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число для сравнения");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(Convert.ToString(number1), " больше чем число ", Convert.ToString(number2));
}
else
{
    Console.WriteLine(Convert.ToString(number2), " больше чем число ", Convert.ToString(number1));
}