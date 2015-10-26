using System;

class LastDigit
{
    static void Main()
    {
        Console.WriteLine("Please write your number:");
        long n = long.Parse(Console.ReadLine());

        long lastDigit = n % (10); //or int or double - whatever numeral data type suits you 
        Console.WriteLine("The last digit of your number {0} is: {1}", n, lastDigit);
    }
}
