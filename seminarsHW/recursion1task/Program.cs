using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion1task
{
    internal class Program
    {
        static void PrintNumbers(int m, int n)
        {
            if (m <= n)
            {
                Console.Write(m);
                if (m != n)
                    Console.Write(", ");
                PrintNumbers(m + 1, n);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат:");
            PrintNumbers(M, N);
            Console.WriteLine();
        }
    }
}
