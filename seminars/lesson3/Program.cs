using System;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecondTask();
            ThirdTask();
            FourthTask();
        }

        static void FourthTask()
        {
            Console.Write("enter a number abc: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] reverseNum = new int[3];
            for (int i = 0; i < reverseNum.Length; i++)
            {
                reverseNum[i] = num % 10;
                num /= 10;
            }
            PrintMatrix(reverseNum);
        }

        static void ThirdTask()
        {
            int[] matrix = GenerateMatrix();
            int[] productOfNumPairs = GenProductOfNumPairs(matrix);
            PrintMatrix(productOfNumPairs);
        }
        static int[] GenProductOfNumPairs(int[] initMat)
        {
            int len = initMat.Length / 2;
            int[] prodNumPairs = new int[len];
            for (int i = 0; i < prodNumPairs.Length; i++)
            {
                prodNumPairs[i] = initMat[i] * initMat[initMat.Length - i - 1];
            }
            if (initMat.Length % 2 == 1) Console.WriteLine($"element {initMat[len]} doesn't have a pair :(");
            return prodNumPairs;
        }

        static void SecondTask()
        {
            int[] matrix = GenerateMatrix();
            Console.Write("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isNumberFound = FindNumInMatrix(num, matrix);
            if (isNumberFound) Console.WriteLine("Да");
            else Console.WriteLine("Нет");
        }

        static int[] GenerateMatrix()
        {
            Console.Write("enter a length of matrix: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] matrix = new int[length];
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = rand.Next(1, 10);
            }
            PrintMatrix(matrix);
            return matrix;
        }

        static bool FindNumInMatrix(int num, int[] mat)
        {
            foreach (int item in mat)
            {
                if (item == num) return true;
            }
            return false;
        }

        static void PrintMatrix(int[] matrix)
        {
            foreach (int item in matrix)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
