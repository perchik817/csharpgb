using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 23.44;
            double b = 46567.78;
            double c = 46.769;
            double d = 11132.35;
            double e = 3536.79;
            double max;

            if(a > b)
            {
                max= a;
            } else if (c > b)
            {
                max = c;
            } else if (d > b)
            {
                max = d;
            } else if (e > b)
            {
                max = e;
            } else
            {
                max = b;
            }


            Console.WriteLine(max);
        }
    }
}
