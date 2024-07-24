using System;

namespace NearValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minRandomValue = 10;
            int maxRandomValue = 51;

            int arrayValue = 30;
            int stepArrayIndex = 1;
            int nextValueArray;
            int backValueArray;

            int nextIndexArray;
            int backIndexArray;

            int[] array = new int[arrayValue];

            int lastIndexValue = array.Length - 1;

            Console.WriteLine("Дан одномерный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nЛокальные максимумы данного массива: ");

            if (array[0] > array[1])
            {
                Console.Write(array[0] + " ");
            }

            for (int i = 1; i < lastIndexValue; i++)
            {
                nextIndexArray = i + stepArrayIndex;
                backIndexArray = i - stepArrayIndex;

                nextValueArray = array[nextIndexArray];
                backValueArray = array[backIndexArray];

                if (backValueArray < array[i] && nextValueArray < array[i])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[lastIndexValue] > array[lastIndexValue - 1])
            {
                Console.Write(array[lastIndexValue] + " ");
            }
        }
    }
}
