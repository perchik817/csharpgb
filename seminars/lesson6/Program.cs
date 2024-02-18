using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Program
    {

        static string CharString(char[] arr)
        {
            string st = "";
            foreach (char item in arr)
            {
                st += item;
            }
            return st;
        }

        static char[] CharArray(string s) 
        {
            char[] arr = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i];
            }
            return arr;
        }
        static void PrintArray(char[] arr)
        {
            foreach (char item in arr)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();
        }

        static int CountVowels(string str)
        {
            int count = 0;
            string vowels = "aoiuye";
            foreach (char item in str.ToLower())
            {
                foreach (char v in vowels)
                {
                    if (item == v) count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            //third task
            Console.WriteLine($"count of vowels: {CountVowels(st)}");
            //second task
            //PrintArray(CharArray(st));


            //first task
            /*char[] chars = new char[] { 'a', 'b', 'c',  'd' };
            string str = CharString(chars);
            Console.WriteLine(str);*/
        }
    }
}
