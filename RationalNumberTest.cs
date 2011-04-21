using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumber
{
    class RationalNumberTest
    {
        static void Main(string[] args)
        { int x;
            RationalNumber r1 = new RationalNumber(10, 20);
            RationalNumber r2 = new RationalNumber(53, 30);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            if (r1.Equals(r2))
            { Console.WriteLine("Ravni sa"); }
            Console.WriteLine(r1 + r2);
            Console.WriteLine("Hashcode 1{0} Hashcode 2{1}", r1.GetHashCode(), r2.GetHashCode());
            r1 = 15;
            Console.WriteLine(r1);
            x = (int)r2;
            Console.WriteLine(x);

        }
    }
}
