using System;

class Average
{
    static void Main()
    {
        //ima li znachenie dali shte se izpolzva int ili double pri parsvaneto ili moje da 
        //sloji double predi average?

        Console.WriteLine("Please write your 1st number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Please write your 2nd number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Please write your 3rd number: ");
        double c = double.Parse(Console.ReadLine());

        double average = (a + b + c) / 3;
        Console.WriteLine("The average sum of these 3 numbers is: {0:F5}", average);

    }
}
