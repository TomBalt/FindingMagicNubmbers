using System;

namespace nd2
{
    class Program
    {
        static void Main()
        {
            int[] Multiplyiers = { 2, 3, 4, 5, 6 };
            foreach (int multiplyier in Multiplyiers)
            {
                Console.WriteLine($"========Looking for a 6 digit magic number which has same numbers than multyplied by {multiplyier} ====");
                for (int number = 100000; number < 999999; number++)
                {

                    int[] number1Array = NumberToArray(number);
                    if (!CheckIfArrayHasUniqueNumbers(number1Array))
                    {
                        continue;
                    }

                    int number2 = number * multiplyier;
                    int[] number2Array = NumberToArray(number2);
                    if (CompareTwoIntArrays(number1Array, number2Array))
                    {
                        Console.WriteLine($"Found a magic number {number} which is multiplied by {multiplyier} has same numbers {number2} ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("Done!");
        }

        static bool CheckIfArrayHasUniqueNumbers(int[] numbers)
        {
            int number;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                for (int z = i + 1; z < numbers.Length; z++)
                {
                    if (number == numbers[z])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        static bool CompareTwoIntArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            Array.Sort(array1);
            Array.Sort(array2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static int[] NumberToArray(int number)
        {
            string numberAsString = Convert.ToString(number);
            int numberLenght = numberAsString.Length;
            int[] numberAsArray = new int[numberLenght];

            for (int i = 0; i < numberLenght; i++)
            {
                numberAsArray[i] = numberAsString[i];

            }
            return numberAsArray;
        }
    }
}
