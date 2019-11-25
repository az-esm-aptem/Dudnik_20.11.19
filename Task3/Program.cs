using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        delegate double myDelegate(double d); 

        static double myMethod(double a, myDelegate del)
        {
            return del(a);
        }

      
        static void Main(string[] args)
        {
            
            double a = myMethod(double.Parse(Console.ReadLine()), x => x * x);
            Console.WriteLine(a);

            a = myMethod(double.Parse(Console.ReadLine()), x => Math.Sqrt(x));
            Console.WriteLine(a);

        }
    }
}
