using System.Collections.Generic;

namespace WebApplicationSample
{
    internal class Day4 //6
    {
        private int AccountBalance = 8000;

        public void print()
        { Console.WriteLine(AccountBalance); }

        public void HeightCategari(int height)
        {
            if (height < 150)
                Console.WriteLine($"for {height} height, Categari: Dwarf");
            else if (height > 160)
                Console.WriteLine($"for {height} height, Categari: Tall");
            else
                Console.WriteLine($"for {height} height, Categari: Average");
        }

        public void PossitiveNumberUsingLinq()
        {

        }

        public void NumberOutputPattern()
        {
            int num = 3;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public void CheckingCharForArithmetic(string checkChar)
        {

            switch (checkChar)
            {
                case "+": Console.WriteLine("arithmetic"); break;
                case "-": Console.WriteLine("arithmetic"); break;
                case "*": Console.WriteLine("arithmetic"); break;
                case "/": Console.WriteLine("arithmetic"); break;

                case "&&": Console.WriteLine("Logical"); break;
                case "||": Console.WriteLine("Logical"); break;

                case "==": Console.WriteLine("Relational"); break;
                case "<": Console.WriteLine("Relational"); break;
                case ">": Console.WriteLine("Relational"); break;
            }
        }

        public void StraitLineOrNot(float x1 , float y1,float x2, float y2, float x3, float y3)
        {
            float m = (y2 - y1) / (x2 - x1);
            float n = (y3 - y2) / (x3 - x2);

            if(m== 0)
                Console.WriteLine("the point are in same line");
            else
                Console.WriteLine("the points are not in the same line");
        }

        public void ConvertHoursToSeconds(int hours)
        {
            int second = 60 * 60 * hours;
            Console.WriteLine(second);
        }

        public void CheckOneValue()
        {
            Console.WriteLine("Enter the char for check: ");
            char checkChar = Convert.ToChar(Console.ReadLine());

            if(char.IsLetter(checkChar))
                Console.WriteLine("input is letter ");
            if (char.IsNumber(checkChar)) 
                Console.WriteLine("input is number ");
            if(char.IsSymbol(checkChar))
                Console.WriteLine("input is symbol ");
        }

        public void DataOperations()
        {
            List<int> number = new List<int>
            {
                10,
                20,
                30,
                40,
                50
            };

            int min = number.Min();
            Console.WriteLine("min "+min);

            int max = number.Max();
            Console.WriteLine("Max: "+ max);

            float avg = (float)number.Average();
            Console.WriteLine("avg: "+ avg);

            int findNumber = 20;
            
            var foundElement = number.Any(x => x == findNumber);
            Console.WriteLine("found Element: "+foundElement);

            var found = number.Contains(findNumber);
            var found1 = number.IndexOf(findNumber);
            Console.WriteLine("found Element: " + found1);
        }
    }

    
}
