// Задача 1 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int num)
{
    if(num >= 10000 && num < 100000)
    {
        return true;
    }
    System.Console.WriteLine("Введенное число не пятизначное");
    return false;
}

int LengthOfNumber(int num)
{
    int lengthNum = 1;
    while (true)
    {
        num = num / 10;
        if (num > 0)
        {
            lengthNum++;
        }
        else
        {
            break;
        }
    }
    return lengthNum;
}

bool IsPalindrom(int num)
{
    int N = LengthOfNumber(num);
    for (int i = 0; i < (N-1)/2; i++)
    {
        v1 = num / Math.Pow(10, N - 1 - i) % 10;
        v2 = num / Math.Pow(10, i) % 10;
        if (v1 != v2)
        {
            return false;
        }
    }
    return true;
}

int number = Promt("Введите пятизначное число");
if(ValidateNumber(number))
{
    if(IsPalindrom(number))
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
