using System.Collections;

namespace WebApplicationSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFunction(121);
            Console.WriteLine("---------");
            MyFunction(1234);

            LogicalPrograms logicalPrograms = new LogicalPrograms();

            logicalPrograms.FriendsName();
            Console.WriteLine("----------------");

            logicalPrograms.SumSquareOfTwo();
            Console.WriteLine("----------------");

            logicalPrograms.PlaceName();
            Console.WriteLine("----------------");

            logicalPrograms.StringNumber();
            Console.WriteLine("----------------");

            logicalPrograms.PartesOfName();
            Console.WriteLine("----------------");

            logicalPrograms.AverageOfFiveNumbers();
            Console.WriteLine("----------------");

            logicalPrograms.PerimeterAndAreaOfCircle();
            Console.WriteLine("----------------");

            logicalPrograms.NextDayDate();
            Console.WriteLine("----------------");

            logicalPrograms.DivisibleBy7();
            Console.WriteLine("----------------");

            // logicalPrograms.ExactTime();

            logicalPrograms.SwapChar();

            AdvanceProgram advanceProgram = new AdvanceProgram();
            //Console.WriteLine("Factorieal: "+ advanceProgram.Factorieal(8));
            //advanceProgram.RootOfQudraticEquation(1,7,12);

            //advanceProgram.ConvertingNumberToString(34);
            //advanceProgram.CheckString("eap");
            //advanceProgram.CheckString("e");
            //advanceProgram.CheckString("rushi");

            //float[] arr = { 10.10f, 20.20f, 30.30f, 60.60f };
            //float avg = advanceProgram.AverageNumbers(arr);
            //Console.WriteLine(avg);

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            //advanceProgram.PrimeNumber(arr);

            //int[] arr = { 12, 0,42,0,4 };
            //advanceProgram.ShiftAllZero(arr);

            //advanceProgram.DuplicteElement();

            //advanceProgram.SepratingOddAndEven();

            //advanceProgram.Factorieal<int>(10);
            //advanceProgram.Factorieal<String>("10");

            //advanceProgram.DeleteElementOfArr();
            //advanceProgram.FindSecondLargestElement();
            //advanceProgram.NonRepetativLongestSubsting();



            SampleClass sampleClass = new SampleClass();
            //sampleClass.SmallestGapInArray();
            //sampleClass.ConvertsDayToYearMonthsAndWeek();
            //sampleClass.SquareRoot();
            //sampleClass.PrimeNumber();
            //sampleClass.SumByInheretance();
            //sampleClass.ReverseWords();
            //sampleClass.SumOfArray();
            //sampleClass.FindFilePathIfNotCreatNewFile();
            //sampleClass.ReadTheFile();
            //sampleClass.TempeRaturConversion();

            //sampleClass.SortingAndSearchingOperationONArray();
            //sampleClass.CollectionOfNameAndPhoneNumber();


            Day4 day4 = new Day4();

            //day4.HeightCategari(149);
            //day4.HeightCategari(161);
            //day4.HeightCategari(155);

            //day4.NumberOutputPattern();
            //day4.CheckingCharForArithmetic("+");
            //day4.CheckingCharForArithmetic("-");
            //day4.CheckingCharForArithmetic("*");
            //day4.CheckingCharForArithmetic("/");
            //day4.CheckingCharForArithmetic("&&");
            //day4.CheckingCharForArithmetic("||");
            //day4.CheckingCharForArithmetic("==");
            //day4.CheckingCharForArithmetic("<");
            //day4.CheckingCharForArithmetic(">");

            //day4.StraitLineOrNot(-2, 2, 2, 5, 6, 8);
            //day4.StraitLineOrNot(1,2,3,4,-10,15);

            //day4.ConvertHoursToSeconds(1);
            //day4.print();
            //day4.DataOperations();

            Day5 day5 = new Day5();
            //day5.IncrasingDigitSum();

            //string[] arr = day5.LongestCommonPrefix();

            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList arrayList =day5.PairInsersion(11,16,14,21);
            //Console.WriteLine(arrayList[0]+" "+ arrayList[arrayList.Count-1]);

            //day5.FindAllDigitWithSumAndNumber();

            //Console.WriteLine(" Multipal: "+day5.CallMultiplOfnumber(2, 4));

            //day5.FindingSumInArray();

            //LinkedList linkedList = new LinkedList();
            //linkedList.AddLast(10);
            //linkedList.AddLast(20);
            //linkedList.AddLast(30);

            //LinkedList linkedList1 = new LinkedList();
            //linkedList1.AddFirst(10);
            //linkedList1.AddFirst(20);
            //linkedList1.AddFirst(30);

            //Day6 day6 = new Day6();
            //int[] arr = day6.getChange(2.66f , 5);
        }

        public static void MyFunction(int number)
        {
            int num = number;
            int rev = 0;
            while (num != 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            if (rev == number)
            {
                Console.WriteLine("number is Palindrom");
            }
            else
            {
                Console.WriteLine("number is not Palindrom");
            }
        }
    }
}