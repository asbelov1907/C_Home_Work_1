/* Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. */

Console.Write("Введите число А - > ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите число B - > ");
double B = double.Parse(Console.ReadLine());

if (A > B) Console.Write("Max = " + A + " , Min = " + B);
else if (A < B) Console.Write("Max = " + B + " , Min = " + A);
else Console.Write("Оба числа равны");
