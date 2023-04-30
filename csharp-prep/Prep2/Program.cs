using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage in number below: ");
        int UserInput = int.Parse(Console.ReadLine());

        if (UserInput >= 90)
        {
            Console.WriteLine("Congrats, you have made an A.");
        }
        else if (UserInput >= 80)
        {
            Console.WriteLine("Congrats, you have made a B.");
        }
        else if (UserInput >= 70)
        {
            Console.WriteLine("Congrats, you have made a C.");
        }
         else if (UserInput >= 60)
        {
            Console.WriteLine("Congrats, you have made a D.");
        }
         else if (UserInput < 60)
        {
            Console.WriteLine("Oops!!, you made F.");
        }
    }
}