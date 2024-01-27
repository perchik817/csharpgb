using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 arrays in c#:
1)  int[] arr = new int[6];
    --- filling arr
2)  int[] arr = new int[6] {1, 35, 67, 679, 567, 34};
3)  int[] arr = {1, 35, 67, 679, 567, 34};
 */

namespace lesson2
{
    internal class Program
    {
        static int[] FirstTask()
        {
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            return arr;
        }

        static void SecondTask()
        {
            int[] arr = FirstTask();
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        static void ThirdTask()
        {
            int[] arr = { 35, 68, 2, 568, 87, 13};
            int i = 0, max = arr[0];

            while (i < arr.Length)
            {
                if (arr[i] > max)
                    max = arr[i];
                Console.Write($"{arr[i]} ");
                i++;
            }

            Console.WriteLine($"\n Max num of array: {max}");
        }

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
    }
}
