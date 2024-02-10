using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcrions
{
    internal class Program
    {
        static bool HasQ(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals("q")) return false;
            }
            return true;
        }

        static bool DigitsSumIsEven(string answer)
        {
            int sum = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                int digit = answer[i];
                sum += digit;
            }
            return sum % 2 == 0;
        }

        static void FirstTask()
        {
            while (true)
            {
                Console.Write("enter num (to stop - q): ");
                string answer = Console.ReadLine();
                if (HasQ(answer) && DigitsSumIsEven(answer)) break;
            }
        }

        static void PrintMatrix(int[] matrix)
        {
            foreach (int item in matrix)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        static int[] GenerateMatrix()
        {
            Console.Write("enter a length of matrix: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] matrix = new int[length];
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = rand.Next(1, 30);
            }
            PrintMatrix(matrix);
            return matrix;
        }
        static int CountEvenNums(int[] array)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0) count++;
            }
            return count;
        }
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static int[] ReverseMatrix(int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }

        static void SecondTask()
        {
            int[] array = GenerateMatrix();
            Console.WriteLine($"Count of even nums in array: {CountEvenNums(array)}");
        }

        static void ThirdTask()
        {
            int[] array = GenerateMatrix();
            int[] reversedArr = ReverseMatrix(array);
            Console.WriteLine("Reversed arr: ");
            PrintMatrix(reversedArr);
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
                Console.WriteLine("Task's solutions menu" +
                "\nChoose from the following:" +
                "\n1. Task №1" +
                "\n2. Task №2" +
                "\n3. Task №3");
                Console.Write("Task's solution №: ");
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
                        Console.WriteLine("Incorrect input.");
                        break;
                }
                choice = Choice();
            }
        }

        static bool Choice()
        {
            Console.WriteLine("Do u want to continue (y/n)? ");
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
                Console.WriteLine("Incorrect input.");
                return true;
            }
        }
    }
}
