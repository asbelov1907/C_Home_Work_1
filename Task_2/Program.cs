/* Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел. */


Console.Write("Введите число А - > ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите число B - > ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите число C - > ");
double c = double.Parse(Console.ReadLine());

double max = a;

if(b>max) max = b;
if(c>max) max = c;

Console.Write("Максимальное число = " + max);