using System;

class PureDivisor
{
    static void Main()
    {
        Console.WriteLine("Please write your number so the program can check \nwhether it can be devided by 9, 11 and 13.");
        int n = int.Parse(Console.ReadLine());

        bool result = (n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0);
        Console.WriteLine("The answer is: {0}", result);
    }
}