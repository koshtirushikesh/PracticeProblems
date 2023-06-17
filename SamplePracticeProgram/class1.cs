using System;

namespace SamplePracticeProgram
{
    internal class class1
    {
        //._COMP_Write a program that generates a random sequence of numbers and stores
        //them in an array, then performs sorting and searching operations on the array.

        public void SortingAndSearchingOperationOnArray()
        {
            int[] intArr = new int[10];

            Random random = new Random();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = random.Next(1, 30);
            }

            int findElement = 20;

            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] == findElement)
                    Console.WriteLine($"Element: {intArr[i]} found at index: {i}");

            }
        }

        //_COMP_Implement a program that performs matrix multiplication,
        //using 2D arrays to store and manipulate the matrices.
        public void MatrixMultiplication()
        {
            int[,] matrix1 = new int[2, 2] {
                 //0  1  
            /*0*/{ 1, 0 }, 
            /*1*/{ 2, 1 },

            };
            int[,] matrix2 = new int[2, 2] {
                 //0  1  
            /*0*/{ 1, 1}, 
            /*1*/{ 0, 0},

            };

            int[,] result = new int[3, 3];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    result[row, col] = CalRowWithCol(row, col);
                }
            }

            int CalRowWithCol(int row, int col)
            {
                int sum = 0;
                for (col = 0; col < 2; ++col)
                {
                    if (row == 2 || col == 2)
                        break;

                    sum += CalRowWithCol(matrix1[row, col], matrix2[col, row]);
                }
                return sum;
            }
        }

        //COMP_Implement a program that generates a sequence of Fibonacci numbers and
        //stores them in an array, then performs various operations on the array,
        //such as finding the sum of the first n numbers or finding the nth number in the sequence.
        public void ArrayOfFibonacciNum()
        {
            int n = 10;
            int[] fibonaccArr = new int[n];

            int num1 = 0, num3 = 0; int num2 = 1;

            fibonaccArr[0] = num1;
            fibonaccArr[1] = num2;
            
            for (int i = 2; i < n; i++)
            {
                num3 = num1 + num2;
                fibonaccArr[i] = num3;
                
                num1 = num2;
                num2 = num3;
            }
        }

        //COMP_Write a program that stores a collection of names and corresponding phone
        //numbers in two separate arrays, allowing the user to search for a name and retrieve
        //the corresponding phone number.
        public void StroringNameAndPhoneNumber()
        {
            string[] testName = { "Rushi", "roy", "anjum" };
            int[] testPhoneNumber = { 1234567890, 0987654321, 543210987 };

            string[] name = new string[3];
            int[] phoneNumber = new int[3];

            for (int i = 0; i < testName.Length; i++)
            {
                name[i] = testName[i];
                phoneNumber[i] = testPhoneNumber[i];
            }

            string findName = "anjum";
            int findIndex = 0;
            bool isFindIndex = false;

            for (int i = 0; i < testName.Length; i++)
            {
                if (name[i] == findName)
                {
                    isFindIndex = true;
                    findIndex = i;
                }
            }

            if (isFindIndex)
                Console.WriteLine("phone Number : " + phoneNumber[findIndex] + " for given Name: " + name[findIndex]);
            else
                Console.WriteLine(" the name name not found.");
        }

        //Implement a program that reads in a set of text data and stores it in an array of strings,
        //then performs various operations on the text, such as searching for a specific word or
        //counting the number of occurrences of a particular letter.
        public void CountingRepetingLetterInString()
        {

        }
    }
}
