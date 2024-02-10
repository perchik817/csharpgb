using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();            
        }
        static void Start()
        {
            bool choice = true;
            int tasksCount = 3;
            while (choice)
            {
                Console.WriteLine("Меню решений заданий" +
                "\nВыберите из нижепредставленных:" +
                "\n1. Задание №1" +
                "\n2. Задание №2" +
                "\n3. Задание №3");
                Console.Write("Решение задания №: ");
                int chosenTask = Convert.ToInt32(Console.ReadLine());

                if (chosenTask <= tasksCount)
                {
                    Tasks(chosenTask);
                }
                choice = Choice();
            }
        }

        static void Tasks(int chosenTask)
        {
            bool choice = true;
            while (choice)
            {
                switch (chosenTask)
                {
                    case 1:
                        FirstTask();
                        break;
                    case 2:
                        SecondTask();
                        break;
                    case 3:
                        ThirdTask();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
                choice = Choice();
            }
        }

        static bool Choice()
        {
            Console.WriteLine("Хотите продолжить (y/n)? ");
            string continueChoice = Console.ReadLine();
            if (continueChoice.Equals("y") || continueChoice.Equals("Y"))
            {
                return true;
            }
            else if (continueChoice.Equals("N") || continueChoice.Equals("n"))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
                return true;
            }
        }

        static void FirstTask()
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            if (Math.Pow(num1, 2) == num2) Console.WriteLine($"Число {num2} является квадратом {num1}");
            else if (Math.Pow(num2, 2) == num1) Console.WriteLine("Число {0} является квадратом {1}", num1, num2);
            else Console.WriteLine("Не является");
        }

        static void SecondTask()
        {

            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                num *= (-1);
            }
            int counter = num * (-1);
            while (counter <= num)
            {
                Console.Write($"{counter} ");
                counter++;
            }
        }
    
        static void ThirdTask()
        {
            Console.Write("Введите трехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstDigit = num / 100;
            int lastDigit = num % 10;
            int sum = firstDigit + lastDigit;
            Console.WriteLine($"Сумма первой и последней цифры = {sum}");
        }
    }
}
