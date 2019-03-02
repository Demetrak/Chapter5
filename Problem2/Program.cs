using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        //5.Напишете програма, която за дадена цифра(0 - 9), зададена като вход, извежда името на цифрата на български език.
        Console.WriteLine("Въведи число по-малко от 9.");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 0:
                Console.WriteLine("Нула");
                break;
            case 1:
                Console.WriteLine("Едно");
                break;
            case 2:
                Console.WriteLine("Две");
                break;
            case 3:
                Console.WriteLine("три");
                break;
            case 4:
                Console.WriteLine("Четири");
                break;
            case 5:
                Console.WriteLine("пет");
                break;
            case 6:
                Console.WriteLine("Шест");
                break;
            case 7:
                Console.WriteLine("Седем");
                break;
            case 8:
                Console.WriteLine("Осем");
                break;
            case 9:
                Console.WriteLine("Девет");
                break;
            default: Console.WriteLine("не познавам това число.");break;

        }



    }
}
