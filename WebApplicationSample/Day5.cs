using System.Collections;

namespace WebApplicationSample
{
    internal class Day5 //5
    {

        public long CallMultiplOfnumber(int number, int n)
        {
            long result = 1;

            for (int i = 0; i < n; i++)
                result *= number;

            return result;
        }
        public void IncrasingDigitSum()
        {
            int num = 5;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {

                    if (i + j == num)
                        Console.Write(" " + i + " " + j);
                }
            }
        }

        public void FindAllDigitWithSumAndNumber()
        {
            int n = 3;
            int sum = 6;
            int i = 0, j = 0, k = 0;
            for (i = 0; i <= 9; i++)
                for (j = 0; j <= 9; j++)
                    for (k = 0; k <= 9; k++)
                        if (i + j + k == 6)
                            Console.WriteLine(" " + i + " " + j + " " + k);

        }

        public ArrayList PairInsersion(int a, int b, int c, int d)
        {
            ArrayList arrayList = new ArrayList();

            for (int i = a; i <= b; i++)
            {
                for (int j = c; j <= d; j++)
                {
                    if (i == j)
                        arrayList.Add(i);
                }
            }

            return arrayList;
        }

        public string[] LongestCommonPrefix()
        {
            string[] arr = { "intelliBlue", "intelliFeeder", "intelliAuth" };
            string[] nameCount = new string[arr.Length];

            for (int index = 0; index < arr.Length; index++)
            {
                string withPrifix = "intelliBlue";
                string withOutPrifix = "";
                for (int i = 0; i < withPrifix.Length; i++)
                {
                    if (char.IsUpper(withPrifix[i]))
                    {
                        break;
                    }
                    else
                    {
                        withOutPrifix += withPrifix[i];
                    }
                }
                nameCount[index] = withOutPrifix;
            }

            return nameCount;
        }

        public void FindingSumInArray()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int sum = 90;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr[i] + arr[j] == sum)
                        Console.WriteLine(arr[i] + " "+ arr[j]);
                }
            }
        }

        public void FindLargestPrimeNumber()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
