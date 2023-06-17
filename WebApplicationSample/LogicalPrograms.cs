using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WebApplicationSample
{
    internal class LogicalPrograms //10
    {
        public virtual void FriendsName()
        {
            string namePatten = "^[A-Z]{1}[a-z]{2,}$";
            string[] FriendsName = { "Rushi", "Ram", "Ravi", "Roy", "shubham" };

            for (int i = 0; i < FriendsName.Length; i++)
            {

                if (Regex.IsMatch(FriendsName[i], namePatten))
                {
                    Console.WriteLine(FriendsName[i] + ": Valide");
                }
                else
                {
                    Console.WriteLine(FriendsName[i] + ": InValide");
                }
            }
        }

        public void SumSquareOfTwo()
        {
            string stringIntPattern = "^[0-9]{1,}$";
            Console.WriteLine("Enter the number 1: ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            if (Regex.IsMatch(Convert.ToString(num1), stringIntPattern))
                Console.WriteLine(num1 + " Valide");
            else
                Console.WriteLine(num1 + " InValide");

            Console.WriteLine("Enter the number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (Regex.IsMatch(Convert.ToString(num2), stringIntPattern))
                Console.WriteLine(num2 + " Valide");
            else
                Console.WriteLine(num2 + " InValide");

            double sum = num1 * num1 + num2 * num2;
            Console.WriteLine("The Sume of Two Numbers: " + sum);

            double differenceSum = num1 * num1 - num2 * num2;
            Console.WriteLine("The Difference of Two Numbers: " + Math.Abs(differenceSum));
        }

        public void PlaceName()
        {
            string namePatten = "^[A-Z]{1}[a-z]{2,}$";
            Console.WriteLine("Enter The Place Name: ");
            string PlaceName = Console.ReadLine();

            if (Regex.IsMatch(PlaceName, namePatten))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

            Console.WriteLine(PlaceName.ToUpper());
            Console.WriteLine(PlaceName.ToLower());
        }

        public void StringNumber()
        {
            string stringIntPattern = "^[0-9]{1,}$";
            Console.WriteLine("Enter the Number: ");
            string number = Console.ReadLine();

            if (Regex.IsMatch(number, stringIntPattern))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

            Console.WriteLine("The number * 10 Print in string: " + Convert.ToString(Convert.ToInt32(number) * 10));
        }

        public void PartesOfName()
        {
            string fullNamePattern = "^[A-z]{1}[a-z]{1,}[ ][A-z]{1}[a-z]{1,}[ ][A-z]{1}[a-z]{1,}$";
            Console.WriteLine("Enter Full Name[First name Last name Middle name]: ");
            string fullName = Console.ReadLine();

            if (Regex.IsMatch(fullName, fullNamePattern))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

            string[] partsOfName = fullName.Split(" ");

            if (partsOfName.Length == 2)
                Console.WriteLine($"First Name : {partsOfName[0]} ; Last Name: {partsOfName[1]}  ");
            if (partsOfName.Length == 3)
                Console.WriteLine($"First Name : {partsOfName[0]} ; Last Name: {partsOfName[1]} ; Middle Name: {partsOfName[2]} ");
        }

        public void AverageOfFiveNumbers()
        {
            Random random = new Random();
            int num1 = random.Next(10, 50);
            int num2 = random.Next(10, 50);
            int num3 = random.Next(10, 50);
            int num4 = random.Next(10, 50);
            int num5 = random.Next(10, 50);

            Console.WriteLine("the Random Numbers: " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5);
            double avg = (double)(num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine("the Average Number: " + avg);
        }

        public void PerimeterAndAreaOfCircle()
        {
            string stringIntPattern = "^[0-9]{1,}.[0-9]{1,}$";
            Console.WriteLine("Enter the Radius of Circle: ");
            double radious = Convert.ToDouble(Console.ReadLine());

            if (Regex.IsMatch(Convert.ToString(radious), stringIntPattern))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");
            double areaOfCircale = 3.14 * radious * radious;
            double perimeterOfCircle = 2 * 3.14 * radious;

            Console.WriteLine($"The Area of Circle: {areaOfCircale} \nThe perimeter of circle {perimeterOfCircle}");
        }

        public void NextDayDate()
        {
            string yearPatten = "^[0-9]{4}$";
            string monthPatten = "^[1-12]{1,2}$";
            string dayPatten = "^[1-31]{1,2}";

            Console.WriteLine("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (Regex.IsMatch(Convert.ToString(year), yearPatten))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

            Console.WriteLine("Month [1 to 12]: ");
            int month = Convert.ToInt32(Console.ReadLine());
            if (Regex.IsMatch(Convert.ToString(month), monthPatten))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

            Console.WriteLine("Input Day [ 1 to 31 ]: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if (Regex.IsMatch(Convert.ToString(day), dayPatten))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

            Console.WriteLine($"the next day is: [{year}-{month}-{day + 1}] ");
        }

        public void ExactTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    Console.Write($"{i}, ");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("\nTime elapsed: {0}", stopwatch.ElapsedMilliseconds);
        }

        public void DivisibleBy7()
        {
            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    Console.Write($"{i}, ");
                }
            }
        }

        public void SwapChar()
        {
            //01234
            string name = "TAPAN";
            string swapName = "";

            int index = 0;
            int nextIndex = 1;

            for (int i = 0; i < name.Length / 2; i++)
            {
                swapName += name[nextIndex].ToString() + name[index];
                index = index + 2;
                nextIndex = nextIndex + 2;

                if (name.Length - 1 == index)
                {
                    swapName = swapName + name[index];
                    Console.WriteLine(swapName);
                    break;
                }
            }
        }
    }
}
