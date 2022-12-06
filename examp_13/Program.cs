// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int numA = ReadInt("Введите число: ");
int numB = ReadInt("Введите степень: ");
ToDegree(numA, numB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}