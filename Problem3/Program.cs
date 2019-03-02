using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        //3.Напишете програма, която намира най - голямото по стойност число, измежду три дадени числа.

        double a, b, c;
        Console.Write("Enter the value of A = : ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of B = : ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of C = : ");
        c = double.Parse(Console.ReadLine());
        if (a < b)
            if (b < c)
            {
                Console.WriteLine("The biggest number is {0}.", c);
            }

        if (a > c )
        {
            Console.WriteLine("The biggest number is {0}",a);

        }


    }
}
