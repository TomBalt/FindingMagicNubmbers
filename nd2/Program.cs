using System;

namespace nd2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting a search of Magic Number!");
            for (int number = 100000; number < 999999; number++)
            {
                int[] number1Array = NumberToArray(number);
                if (!CheckIfArrayHasUniqueNumbers(number1Array))
                {
                    continue;
                }

                FindAMagicNymber(number);
   
            }
            Console.ReadKey();
            Console.WriteLine("Done!");
        }

        static void FindAMagicNymber(int number)
        {

            int[] number1Array = NumberToArray(number);

            int[] number2Array = NumberToArray(number * 2);
            int[] number3Array = NumberToArray(number * 3);
            int[] number4Array = NumberToArray(number * 4);
            int[] number5Array = NumberToArray(number * 5);
            int[] number6Array = NumberToArray(number * 6);
            if (CompareTwoIntArrays(number1Array, number2Array) && CompareTwoIntArrays(number1Array, number3Array) && CompareTwoIntArrays(number1Array, number4Array) && CompareTwoIntArrays(number1Array, number5Array) && CompareTwoIntArrays(number1Array, number6Array))
            {
                Console.WriteLine("Magic number: " + number);

            }
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
