using System;

namespace AbrArrays
{
    class MyArrays
    {
        static void Main(string[] args)
        {
            ExecuteFirstTask();

            Console.WriteLine();

            ExecuteSecondTask();

            Console.ReadLine();
        }

        static void ExecuteFirstTask()
        {
            int[] simpleArray = new int[6];

            Console.WriteLine("First Task");
            Console.WriteLine("Enter 6 array elements");
            Console.WriteLine();

            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.WriteLine("{0} element: ", i + 1);

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userInputToInt))
                {
                    simpleArray[i] = userInputToInt;
                }
                else
                {
                    Console.WriteLine("Enter element is not integer!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Original array: ");

            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.Write(simpleArray[i] + " ");
            }

            Console.WriteLine();

            Array.Sort(simpleArray);
            Array.Reverse(simpleArray);

            Console.WriteLine("Array with sorted from high to low elements");

            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.Write(simpleArray[i] + " ");
            }

            Console.WriteLine();
        }

        static void ExecuteSecondTask()
        {
            Console.WriteLine("Second task");
            Console.WriteLine("Dual array:");
            Console.WriteLine();

            int[,] dualArray = new int[,] { { 16, 27, 3 }, { 19, 5, 84 } };

            int[] maxElements = new int[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{dualArray[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                int maxElement = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (j == 0 || maxElement < dualArray[i, j])
                    {
                        maxElement = dualArray[i, j];
                    }
                    maxElements[i] = maxElement;
                }
            }

            for (int i = 0; i < maxElements.Length; i++)
            {
                Console.WriteLine("Max element of {0} line is: {1}", i + 1, maxElements[i]);
            }
        }
    }
}
