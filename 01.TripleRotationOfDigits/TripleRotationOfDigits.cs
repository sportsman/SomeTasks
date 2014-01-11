using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TripleRotationOfDigits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        if (K<10)
        {
            Console.WriteLine(K);
        }
        else if (K > 9 && K < 99)
        {
            int last = K % 10;
            int firstBeforeLast = K / 10;
            if (last == 0)
            {
                Console.WriteLine(firstBeforeLast);
            }
            else if (firstBeforeLast == 0)
            {
                Console.WriteLine(last);
            }
            else
            {
                Console.WriteLine("" + last + firstBeforeLast);
            }
        }
        else if (K > 99)
        {
            int last3 = (K / 100) % 10;
            if (last3 != 0)
            {
                Console.Write(last3);
            }
            int last2 = (K / 10) % 10;
            if (last2 != 0)
            {
                Console.Write(last2);
            }
            int last1 = K % 10;
            if (last1!=0)
            {
                Console.Write(last1);
            }           
            if (K/1000!=0)
            {
                Console.Write(K / 1000);
            }


        }
    }
}

