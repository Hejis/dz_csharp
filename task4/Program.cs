//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int  N = Convert.ToInt32(Console.ReadLine());
int x=2;

while (x < N)
 {
    Console.WriteLine(x);
    x = x + 2;
 };

