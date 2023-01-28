/* Author: Anastasia Clements
 * Course: COMP-003A
 *Purpose: Assignment 2 (working with strings and math) */
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Comp-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            int yearDifference = Convert.ToInt32(inputAge) - 19;
            if (yearDifference == 0)
                {Console.WriteLine($"Hi {firstName} {middleName} {lastName}! You were born in {yearBorn}. We are the same age!");}
            else if (yearDifference > 0)
                {Console.WriteLine($"Hi {firstName} {middleName} {lastName}! You were born in {yearBorn}. You are {yearDifference} year(s) older than me!");}
            else
                {Console.WriteLine($"Hi {firstName} {middleName} {lastName}! You were born in {yearBorn}. You are {-yearDifference} year(s) younger than me!");}
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Please input integer value a");
            string mathInput1 = Console.ReadLine();
            Console.WriteLine("Please input integer value b");
            string mathInput2 = Console.ReadLine();

            int integerA = Convert.ToInt32(mathInput1);
            int integerB = Convert.ToInt32(mathInput2);


            Console.WriteLine("  Integer Math:");
            Console.WriteLine($"      Addition|{integerA,5} + {integerB} = {integerA + integerB}");
            Console.WriteLine($"   Subtraction|{integerA,5} - {integerB} = {integerA - integerB}");
            Console.WriteLine($"Multiplication|{integerA,5} * {integerB} = {integerA * integerB}");
            Console.WriteLine($"      Division|{integerA,5} / {integerB} = {integerA / integerB}");
            Console.WriteLine($"        Modulo|{integerA,5} % {integerB} =  {integerA % integerB}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Please input radius of circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("  Calculations:");
            Console.WriteLine($"          Area|     π * {radius} ^ 2 = {area}");
            Console.WriteLine($" Circumference|     2 * π * {radius} = {circumference}");


        }
    }
}