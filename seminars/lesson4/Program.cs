using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Program
    {
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
        static bool IsSimple(int num) 
        {
            for (int i = 0; i < Convert.ToInt32(Math.Sqrt(num)); i++)
            {
                if (num % 2 == 0) return true;
            }
            return false;
        }
        static int Count(int[] matrix)
        {
            int count = 0;
            foreach (int item in matrix)
            {
                //first task
                //if(IsSimple(item)) count++;

                //second task
                if (EndsWithOne(item) && IsDividedBy7(item)) count++;
            }
            return count;
        }
        static bool EndsWithOne(int num) 
        {
            return num % 10 == 1;
        }
        static bool IsDividedBy7(int num)
        {
            return num % 7 == 0;
        }
        static int MakeNumFromMatrix(int[] matrix)
        {
            int madeNum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                madeNum = madeNum * 10 + matrix[i];
            }
            return madeNum;
        }
        static void Main(string[] args)
        {
            int[] matrix = GenerateMatrix();
            //first and second tasks
            //Console.WriteLine(Count(matrix));

            //third task
            Console.WriteLine(MakeNumFromMatrix(matrix));
        }
        
    }
}
