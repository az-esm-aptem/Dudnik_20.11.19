using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate bool circleDelegate(); 

       
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("R = ");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine();

            circleDelegate isInCircle = () =>
            {
            if (R * R >= x * x + y * y) return true;
            return false;
            };

            Console.WriteLine(isInCircle());
        }
    }
}
