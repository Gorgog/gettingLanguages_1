//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int len = GetInt("Длина массива: ");
int start = GetInt("Начальное значение: ");
int end = GetInt("Конечное значение: ");
Console.WriteLine($"[{string.Join(", ", Generate(len, start, end))}]");

int GetInt(string msg)
{
    int result;
    Console.Write(msg);
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write("Пожалуйста, введите корректное число: ");
    }
    return result;
}

int[] Generate(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


