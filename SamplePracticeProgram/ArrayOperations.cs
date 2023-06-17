using System;

namespace SamplePracticeProgram
{
    // COMP_Write a program that stores a set of numerical data in an array and performs
    // various operations on it, such as finding the maximum or minimum value,
    // calculating the average, and sorting the array in ascending or descending order.
    internal class ArrayOperations
    {

        int[] intArr = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        public void AddDataToArray()
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine("Enter element " + i);
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void FindingMaximum()
        {
            int max = intArr[0];

            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] > max)
                    max = intArr[i];
            }

            Console.WriteLine("Max: " + max);
        }

        public void FindingMinmum()
        {
            int min = intArr[0];

            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] < min)
                    min = intArr[i];
            }
        }

        public void CalCulatingAverage()
        {
            int sum = 0;

            for (int i = 1; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }
            Console.WriteLine("Sum: " + sum);
        }

        public void SortingAssanding()
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (i == j)
                        continue;
                    ///    20 < 10
                    if (intArr[i] > intArr[j])
                    {
                        int temp = intArr[i];
                        intArr[i] = intArr[j];
                        intArr[j] = temp;
                    }
                }
            }
        }

        public void SortingDesending()
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (i == j)
                        continue;
                    ///    20 < 10
                    if (intArr[i] < intArr[j])
                    {
                        int temp = intArr[i];
                        intArr[i] = intArr[j];
                        intArr[j] = temp;
                    }
                }
            }
        }
    }
}
