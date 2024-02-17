using System;
class Interval
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a real number:");
        double x;

        if (double.TryParse(Console.ReadLine(), out x))
        {
            bool isInInterval =
                ((x >= 2 && x < 3)
                || (x > 0 && x <= 1)
                || (x > -10 && x <= -2));

            if (isInInterval)
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
        }
    }
}