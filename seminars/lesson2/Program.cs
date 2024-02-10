using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();

        }

        static void FourthTask()
        {
            Console.Write("Enter a num: ");
            string userNum = Console.ReadLine();
            int userNumLen = userNum.Length;
            if (userNumLen < 3)
                Console.WriteLine("There is no third digit");
            else
            {
                string digit3start = Convert.ToString(userNum[2]);
                Console.WriteLine($"Third digit from the beginning: {digit3start}");
                string digit3end = Convert.ToString(userNum[userNumLen - 3]);
                Console.WriteLine($"Third digit from the end: {digit3end}");
            }
        }

        static void ThirdTask()
        {
            Console.Write("Enter a first num: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second num: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int residue = userNum1 % userNum2;
            if (residue == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine($"no, {residue}");
        }
        static void SecondTask()
        {
            Console.Write("Enter a num from 100 till 999: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int digit2 = userNum / 10 % 10;
            int digit3 = userNum % 10;
            int result = (int)Math.Pow(digit2, digit3);
            Console.WriteLine($"{digit2} ^ {digit3} = {result}");
        }
        
        static void FirstTask()
        {
            int num = new Random().Next(100, 1000);
            int digit1 = num / 100;
            int digit2 = num % 10;
            Console.WriteLine($"num: {num}\ndigit1: {digit1}\ndigit2: {digit2}");
            Console.WriteLine($"new num: {digit1 * 10 + digit2}");
        }
    }
}
