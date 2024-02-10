using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class Program
    {
        static int[,] GenerateMatrix()
        {
            Console.Write("enter a number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }

            return matrix;
        }
        static void PrintMatrix(int[,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintArray(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        static int[,] Sq(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0) 
                        array[i, j] = (int)Math.Pow(array[i, j], 2);
                }
            }
            return array;
        }
        static int DiagonalElsSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        sum += array[i, j];
                }
            }
            return sum;
        }
        static double[] RowsElsAvr(int[,] matrix)
        {
            double[] rowAverages = new double[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }
                rowAverages[i] = rowSum / matrix.GetLength(1);
            }
            return rowAverages;
        }
        static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix();
            PrintMatrix(matrix);
            Console.WriteLine();
            //first task
            //PrintMatrix(Sq(matrix));

            //second task
            //Console.WriteLine($"Sum of elements on the main diagonal: {DiagonalElsSum(matrix)}");

            //third task
            PrintArray(RowsElsAvr(matrix));
            
        }
    }
}
