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

bool IsPalindrom(int num)
{
    countNum = 0;
    while (true)
    {
        if (countNum)
        {
            countNum++;
        }
        else
        {
            break;
        }
    }
    int n1 = num /10000;
    int n2 = num /1000 % 10;
    //int n3 = num /100 % 10;
    int n4 = num /10 % 10;
    int n5 = num % 10;
    if(n1 == n5 && n2 == n4)
    {
        return true;
    }
    return false;
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
