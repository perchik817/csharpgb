using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrsStrs
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
        static string ToLower(string s)
        {
            return s.ToLower();
        }

        static bool isPalindrom(string str)
        {
            str.ToLower();
            int start = 0;
            int end = str.Length - 1;

            while (start < end)
            {
                if (str[start] != str[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }

        static string ReverseStr(string str)
        {
            string reversedStr = "";

            if (str == null) return null;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                string subStr = "";
                while (i >= 0 && str[i] != ' ')
                {
                    subStr = str[i] + subStr;
                    i--;
                }
                reversedStr += subStr + " ";
            }
            return reversedStr.Trim();
        }
        static void Main(string[] args)
        {

            //Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
            /*char[] chars = new char[] { 'a', 'b', 'c', 'd' };
            string str = CharString(chars);
            Console.WriteLine(str);*/


            //Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
            /*string str = "adksYUOfsjakIosdKL";
            Console.WriteLine(ToLower(str));*/


            //Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
            /*string palindrom = "abcddcba";
            Console.WriteLine($"{palindrom} is a palindrom? - {isPalindrom(palindrom)}");*/


            //Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном 
            //порядке. В полученной строке слова должны быть также разделены пробелами.
            string satze = "ich lerne deutsch";
            Console.WriteLine(ReverseStr(satze));

        }
    }
}
