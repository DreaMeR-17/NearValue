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

            int numbersValue = 30;
            int nextValue;
            int backValue;

            int nextIndex;
            int backIndex;

            int[] numbers = new int[numbersValue];

            int lastIndex = numbers.Length - 1;

            Console.WriteLine("Дан одномерный массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nЛокальные максимумы данного массива: ");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < lastIndex; i++)
            {
                nextIndex = i + 1;
                backIndex = i - 1;

                nextValue = numbers[nextIndex];
                backValue = numbers[backIndex];

                if (numbers[i] > nextValue && numbers[i] > backValue)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers[lastIndex] > numbers[lastIndex - 1])
            {
                Console.Write(numbers[lastIndex] + " ");
            }
        }
    }
}
