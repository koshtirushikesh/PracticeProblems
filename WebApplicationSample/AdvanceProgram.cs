namespace WebApplicationSample
{
    internal class AdvanceProgram //10
    {
        internal int num1 = 10;
        internal int num2 = 20;
        public void Factorieal<T>(T number)
        {
            //int num = number;
            //long sum = 1;

            //for (int i = num; i > 0; i--)
            //{
            //    sum = sum * i;
            //}
            //return sum;
            Console.WriteLine(number);
        }

        public long Factorieal(int number, int number2)
        {
            int num = number;
            long sum = 1;

            for (int i = num; i > 0; i--)
            {
                sum = sum * i;
            }
            return sum;
        }

        public void Recursion()
        {
            int i = 1;
            if (i <= 100)
            {
                i++;
                Console.Write(" " + i);
                Recursion();
            }
        }

        public void RootOfQudraticEquation(int a, int b, int c)
        {
            double squerRoot = Math.Sqrt(b * b - 4 * a * c);
            double n_X = (-b - squerRoot) / 2 * a;
            double p_X = (-b + squerRoot) / 2 * a;
            Console.WriteLine(n_X + " " + p_X);
        }

        public void ConvertingNumberToString(int num)
        {
            if (num % 3 == 0)
                Console.Write("Pling");
            if (num % 5 == 0)
                Console.Write("Plang");
            if (num % 7 == 0)
                Console.Write("Plong");

            if (num % 3 != 0 && num % 5 != 0 && num % 7 != 0)
                Console.Write(num.ToString());
        }

        public void CheckString(string name)
        {
            if (name.Contains('a') && name.Contains('e') && name.Contains('p'))
                Console.WriteLine("All present");
            else if (name.Contains('a') || name.Contains('e') || name.Contains('p'))
                Console.WriteLine("One or more - Present");
            else
                Console.WriteLine("None Present");
        }

        public float AverageNumbers(float[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public int[] PrimeNumber(int[] arr)
        {
            string primeNumString = "";
            foreach (var number in arr)
            {
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    { isPrime = false; break; }
                }

                if (isPrime)
                    primeNumString = primeNumString + " " + number;
            }
            Console.WriteLine(primeNumString);

            string[] chars = primeNumString.Split(" ");
            int[] primeNumber = new int[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                primeNumber[i] = Convert.ToInt32(chars[i]);
            }
            return primeNumber;
        }

        public void ShiftAllZero(int[] arr) //18
        {
            int[] nonZeroArr = new int[arr.Length];
            int element = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    nonZeroArr[element++] = arr[i];
                }
            }
        }

        public void DeleteElementOfArr()
        {
                        // 0   1   2   3   4   5  
            int[] arr = { 10, 20, 30, 40, 50, 60 };

            int deleteElementAt = 4;

            for (int i = 0; i < arr.Length; i++)
            {
                if (deleteElementAt >= arr.Length - 1)
                {
                    arr[i] = 0;
                    break;
                }

                if (i >= deleteElementAt)
                {
                    arr[i] = arr[++deleteElementAt];
                }
            }
        }

        public void FindSecondLargestElement()
        {
            // 0   1   2   3   4   5   6   7    8   9
            int[] arr = new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };

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

            Console.WriteLine("Second largest element: " + arr[arr.Length - 2]);
        }

        public void NonRepetativLongestSubsting()
        {
            // not completed
            //string[] arr = { "ABDEFGABEF" };
                         //0123456789
            string name = "ABDEFGABEF";
            string nonRepName = "";
            
            for (int i = 0; i < name.Length; i++)
            {
                if (!nonRepName.Contains(name[i]))
                {
                    nonRepName = nonRepName + name[i];
                }
            }
            Console.WriteLine(nonRepName.Length);
        }

        public void DuplicteElement()
        {               // 0   1   2   3   4   5   6  7   8
            int[] arr = { 10, 20, 30, 40, 50, 60, 20, 30, 10 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr[i] == arr[j])
                        count++;
                }
            }

            Console.WriteLine(" Count: " + count / 2);
        }

        public void SepratingOddAndEven()
        {              // 0  1  2  3  4  5  6  7  8  9   10  11  12  13
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 17 };

            int odd = 0;
            int even = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
            }

            int[] oddArr = new int[odd + 1];
            int[] evenArr = new int[even + 1];
            odd = 0; even = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[even] = arr[i];
                    even++;
                }
                else
                {
                    oddArr[odd] = arr[i];
                    odd++;
                }
            }

            Console.WriteLine();
        }
    }
}
