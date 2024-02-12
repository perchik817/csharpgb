using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion3task
{
    internal class Program
    {
        static void PrintArrayReverse(int[] array, int index)
        {
            if (index >= 0)
            {
                Console.Write($"{array[index]} ");
                PrintArrayReverse(array, index - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива (разделите пробелом): ");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(input, int.Parse);

            Console.Write("Результат: [");
            PrintArrayReverse(array, array.Length - 1);
            Console.WriteLine("]");
        }
    }
}
