// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.WriteLine("Пожалуйста, введите первое число:");
int task01Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе число:");
int task01Number2 = Convert.ToInt32(Console.ReadLine());

if (task01Number1 > task01Number2) 
    {
        Console.WriteLine("Максимальное число = " + task01Number1);
        Console.WriteLine("Минимальное число = " + task01Number2);
    } else {
        Console.WriteLine("Максимальное число = " + task01Number2);
        Console.WriteLine("Минимальное число = " + task01Number1);
    }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.WriteLine("Пожалуйста, введите первое число:");
int task02Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе число:");
int task02Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите третье число:");
int task02Number3 = Convert.ToInt32(Console.ReadLine());

int task02Max = Math.Max(Math.Max(task02Number1, task02Number2), task02Number3);

Console.WriteLine("Максимальное число = " + task02Max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.WriteLine("Пожалуйста, введите первое число:");
int task03Number1 = Convert.ToInt32(Console.ReadLine());

if (task03Number1 % 2 == 0) 
    {
        Console.WriteLine("Число " + task03Number1 + " четное");
    } else {
        Console.WriteLine("Число " + task03Number1 + " не четное");
    }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.WriteLine("Пожалуйста, введите число до которого будем считать чётные числа:");
int task04Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа до: " + task04Number1);
for (int i = 1; i < task04Number1; i++)
{
    
    if (i % 2 == 0) 
    {
        Console.WriteLine(i);
    }
    
}