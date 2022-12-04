/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
int UserNumber = getUserInt("Введите число");
int sumOfDigit = GetSumOfDigit(UserNumber);
Console.WriteLine($"Сумма цифр числа {UserNumber} равна {sumOfDigit}");
int GetSumOfDigit(int UserNumber)
{
    if (UserNumber == 0)
    {
        return 0;
    }
    return UserNumber % 10 + GetSumOfDigit(UserNumber / 10);
}

