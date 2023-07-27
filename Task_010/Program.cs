//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Пожалуйста, введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

if(number >= 100 && number <= 999){
    Console.WriteLine(SecondNumber(number));
} else {
     Console.WriteLine("Число не является трехзначным");
}

int SecondNumber(int number) {
    int secontNumber = (number / 10) % 10;
    return secontNumber;
};
