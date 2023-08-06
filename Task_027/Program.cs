//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int userInput = GetInputFromUser("Введите число: ");
Console.Write($"Сумма всех цифр в числе {userInput} = {CalculateDigitSum(userInput)}");

int GetInputFromUser(string promptMessage)
{
    Console.Write(promptMessage);
    if (int.TryParse(Console.ReadLine(), out int parsedInput))
        return parsedInput;
    else
    {
        Console.WriteLine("Пожалуйста, введите корректное число.");
        return GetInputFromUser(promptMessage);
    }
}

int CalculateDigitSum(int num)
{
    int sum = 0;
    while (num > 0) 
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

