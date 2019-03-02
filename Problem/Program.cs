using System;

class Program
{
    static void Main()
    {
        //7.Напишете програма, която намира най - голямото по стойност число измежду дадени 5 числа.
        double a, b, c, d, e;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c =");
        c = double.Parse(Console.ReadLine());
        Console.Write("d =");
        d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        e = double.Parse(Console.ReadLine());
        if (a < b) a = b;
        if (a < c) a = c;
        if (a < d) a = d;
        if (a < e) a = e;
        Console.WriteLine("{0} is the biggest number.",a);



    }
}
