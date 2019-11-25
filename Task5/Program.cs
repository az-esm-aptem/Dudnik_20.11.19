using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        
        public delegate T myDelegate <T>(T a, T b);
        public static event myDelegate <int> myIntEvent;

        
        static void Main(string[] args)
        {
            const int A = 5;
            const int B = 7;
            myIntEvent += (x, y) => x + y;

            Console.WriteLine(myIntEvent?.Invoke(A, B));
        }
    }
}
