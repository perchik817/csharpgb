using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(8));
        }

        static int Factorial(int x)
        {
            if (x == 0 || x == 1)
            {
                Console.WriteLine($"Stop recursion: x = {x}");
                return 1;
            }
            int fact = Factorial(x - 1);
            Console.WriteLine($"Возврат: x = {x}, factorial = {fact}");
            return x * fact;
        }
    }
}
