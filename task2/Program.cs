// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите 3 числа для сравнения");
Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int c = Convert.ToInt32(Console.ReadLine());
 
int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

 Console.WriteLine($"Число {max} наибольшее");