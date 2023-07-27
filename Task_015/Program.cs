// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Пожалуйста, введите цифру обозначающую день недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (DayOff(number)) {
    Console.Write($"Введенная цифра дня недели {number} это выходной день");
} else {
    Console.Write($"Введенная цифра дня недели {number} не является выходным днём или не соответствует цифрам дней недели");
}

bool DayOff(int number) {
    if (number >= 1 && number <= 7) {
        if (number == 6 || number == 7) {
            return true;
        } else {
            return false;
        }
    } else {
        return false;
    }
};
