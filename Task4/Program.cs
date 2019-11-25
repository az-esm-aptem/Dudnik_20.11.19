using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int A = 5;
            const int B = 6;

            Func<int, int, bool> areEqual = (x, y) => x == y ? true : false;
            Func<double, double, double> add = (x, y) => x + y;

            Console.WriteLine(areEqual(A, B));
            Console.WriteLine(areEqual(B, B));
            Console.WriteLine(add(A, B));
        }
    }
}
