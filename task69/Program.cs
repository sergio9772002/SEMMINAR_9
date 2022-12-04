/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int StartIndex = getUserInt("Введите A");
int EndIndex = getUserInt("Введите B");
int multOfDigit = MultNumber(StartIndex, EndIndex);
Console.WriteLine($"А в степери В равно {multOfDigit}");
int MultNumber(int Index1, int Index2)
{
    if (Index2 == 0)
    {
        return 1;
    }
    return MultNumber(Index1, Index2 - 1) * Index1;
}
