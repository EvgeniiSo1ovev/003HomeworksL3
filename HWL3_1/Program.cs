// Задача 1 Напишите программу, которая принимает на вход любое число 
// и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Reverse(int number)
{
    int answer = 0;
    while (number > 0)
    {
        answer = answer * 10 + number % 10;
        number = number / 10; // number /=10
    }
    return answer;
}

bool IsPalindrom(int num)
{
    //if(num == Reverse(num))
    //{
    //    return true;
    //}
    //return false;
    //нижнее заменяет всё верхнее
    return num == Reverse(num)
}

int number = Promt("Введите пятизначное число");
if(IsPalindrom(number))
{
    System.Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {number} не является палиндромом");
}
