// See https://aka.ms/new-console-template for more information


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
  

int num = ReadInt("Введите число: ");

int len = NumberLen(num);
SumNumbers(num, len);

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int k = 0;
    while (a > 0)
    {
        a /= 10;
        k++;
    }
    return k;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}