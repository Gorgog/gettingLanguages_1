//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int baseNumber = GetInput("Введите основание: ");
int powerValue = GetInput("Введите степень: ");

if (IsValidPower(powerValue))
    Console.WriteLine($"Число {baseNumber} в степени {powerValue} равно {CalculatePower(baseNumber, powerValue)}");

int GetInput(string message) {
    Console.Write(message);
    
    if (int.TryParse(Console.ReadLine(), out int parsedValue))
        return parsedValue;
    
    Console.WriteLine("Введите корректное число.");
    return GetInput(message);
}

int CalculatePower(int baseNumber, int powerValue) {
    int result = 1;
    for (int i = 0; i < powerValue; i++) result *= baseNumber;
    return result;
}

bool IsValidPower(int powerValue) {
    if(powerValue < 0) {
        Console.WriteLine("Степень не должна быть меньше нуля");
        return false;
    }
    return true;
}

