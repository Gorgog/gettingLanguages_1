// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number)) {
    Console.WriteLine("Число является палиндромом");
    } else {
    Console.WriteLine("Число не является палиндромом");
    }

static bool IsPalindrome(int number) {

    int originalNumber = number;
    int reversedNumber = 0;

    for (int i = 0; i < 5; i++) {
        reversedNumber = reversedNumber * 10 + (number % 10);
        number /= 10;
    }

    return originalNumber == reversedNumber;
}
