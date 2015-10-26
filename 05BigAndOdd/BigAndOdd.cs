using System;

class BigAndOdd
{
    static void Main()
    {
        Console.WriteLine("Please write your number:");
        int n = int.Parse(Console.ReadLine());

        bool result = (n > 20) && (n % 2 != 0);
        Console.WriteLine(result); //true or false
    }
}