using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
  // Печать массива
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создаем новый массив, чтобы не изменять оригинальный
        int[,] newArray = new int[rows, cols];

        // Копируем последнюю строку в новый массив
        for (int j = 0; j < cols; j++)
        {
            newArray[0, j] = array[rows - 1, j];
        }

        // Копируем первую строку в новый массив
        for (int j = 0; j < cols; j++)
        {
            newArray[rows - 1, j] = array[0, j];
        }

        // Копируем оставшиеся строки в новый массив
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                newArray[i, j] = array[i, j];
            }
        }

        return newArray;
    }

    // Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
        // Обмен значений между i-м и последним элементами в строке
        int temp = array[i, array.GetLength(1) - 1];
        array[i, array.GetLength(1) - 1] = array[i, 0];
        array[i, 0] = temp;
    }

    public static void PrintResult(int[,] numbers)
    {
        // Обмен первой и последней строк
        int[,] swappedArray = SwapFirstLastRows(numbers);

        // Печать массива
        PrintArray(swappedArray);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
