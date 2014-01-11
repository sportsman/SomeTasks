using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UKFlag
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int middleDots = N/2-1;

        for (int i = 1; i <= N/2; i++)
        {
            int leftAndRightDots = i - 1;
            Console.Write(new string('.', leftAndRightDots));
            Console.Write("\\");
            Console.Write(new string('.', middleDots));
            Console.Write("|");
            Console.Write(new string('.', middleDots));
            Console.Write("/");
            Console.Write(new string('.', leftAndRightDots));
            middleDots--;
            Console.WriteLine();
        }

        int numberOfDashes = N / 2;

        Console.Write(new string('-',numberOfDashes));
        Console.Write("*");
        Console.Write(new string('-', numberOfDashes));
        Console.WriteLine();

        middleDots = 0;

        for (int i = N/2; i >= 1; i--)
        {
            int leftAndRightDots = i - 1;
            Console.Write(new string('.', leftAndRightDots));
            Console.Write("/");
            Console.Write(new string('.', middleDots));
            Console.Write("|");
            Console.Write(new string('.', middleDots));
            Console.Write("\\");
            Console.Write(new string('.', leftAndRightDots));
            middleDots++;
            Console.WriteLine();
        }

    }
}

