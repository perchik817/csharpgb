using System;
using System.Dynamic;
using System.Linq;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = CreateMatrix(6, 5);
            PrintMatrix(matrix);
            PrintInterestingNumbers(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix Elements:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintInterestingNumbers(int[,] matrix)
        {
            Console.WriteLine("Interesting Numbers:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    if (IsSumOfDigitsEven(num))
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }

        static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10, 100);
                }
            }
            return matrix;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsSumOfDigitsEven(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return IsEven(sum);
        }
    }
}
