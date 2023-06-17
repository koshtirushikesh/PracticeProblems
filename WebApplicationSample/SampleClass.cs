namespace WebApplicationSample
{
    internal class SampleClass : AdvanceProgram //11
    {
        public void SmallestGapInArray()
        {
            int[] arr = { 7, 5, 8, 9, 11, 23, 18 };

            Array.Sort(arr);
            int min = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length; i = i + 2)
            {
                if (arr.Length - 1 == i)
                    break;
                if (min > arr[i + 1] - arr[i])
                    min = arr[i + 1] - arr[i];
            }
            Console.WriteLine(min);
        }

        public void ConvertsDayToYearMonthsAndWeek()
        {
            int day = 768;
            int year = day / 365;
            int month = day / 30;
            int week = day / 7;
            Console.WriteLine(" day: " + day + "\n year: " + year + " Month: " + month + " weeek: " + week);
        }

        public void SquareRoot()
        {


        }

        public void PrimeNumber()
        {
            for (int num = 2; num <= 100; num++)
            {
                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num == 2)
                        continue;
                    if (num % i == 0)
                    {
                        isPrime = false; break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }
        }

        public void SumByInheretance()
        {
            int sum = num1 + num2;
            Console.WriteLine($"\nsum of {num1} + {num2} : " + sum);
        }

        public void TempeRaturConversion()
        {
            double celsius = 27;

            double kelvin = celsius + 273.15;

            double fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine(" celsius " + celsius + "to kelvin: " + kelvin + "to fahrenheit: " + fahrenheit);
        }

        public void ReverseWords()
        {
            string words = "Display the pattern like pyramid using the alphabet.";

            string[] wordsArr = words.Split(' ');

            for (int i = wordsArr.Length - 1; i >= 0; i--)
            {
                Console.Write(wordsArr[i] + " ");
            }
        }

        public void SumOfArray()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("\nSum of array element: " + sum);
        }

        public void FindFilePathIfNotCreatNewFile()
        {
            string filePath = @"c:/csharp/ex/test.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("File path exist");
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                Console.WriteLine("File Path was not present, so creating new path");
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Hello, we have created new file");
                    sw.WriteLine("This is the test file reading the second line");
                }
            }
        }

        public void ReadTheFile()
        {
            string filePath = @"c:/csharp/ex/test.txt";

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("File Not Found ");
            }
        }

        public void SortingAndSearchingOperationONArray()
        {
            int findNum = 20;
            int indexOfNum = 0;
            bool isNumExist = false;

            int[] arr = new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };

            //Random random = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(1, 100);
            //}

            // 0   1  2  3  4  5
            // 60 50 40 30 20 10

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //   60  > 50 
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (findNum == arr[i])
                {
                    indexOfNum = i;
                    Console.WriteLine(" The number was found at: " + indexOfNum);
                }
            }

            if (isNumExist)
                Console.WriteLine(" The number was found At: " + indexOfNum);
            else
                Console.WriteLine(" the number was not found in array");


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public void CollectionOfNameAndPhoneNumber()
        {
            Console.WriteLine();
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
    }
}
