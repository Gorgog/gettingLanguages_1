//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Пожалуйста, введите произвольное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if (number < 100) {
    Console.Write("У введенного числа нету 3 знака");
} else {
    Console.WriteLine(SecondNumber(number));
}

int SecondNumber(int number) {

    while (number >= 1000) {
            number /= 10;
        }

    int thirdDigit = number % 10;
    return thirdDigit;
};
