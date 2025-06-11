// See https://aka.ms/new-console-template for more information


using System.Net;
using System.Security.Cryptography;

namespace FirstConsoleApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Console.WriteLine("******** Basic Console Commands ********");
            // GetUserData();

            // Console.WriteLine("******** Basic Numeric formatting Commands ********");
            // FormatNumericalData();

            // Console.WriteLine("===> Data Declarations:");
            // LocalVarDeclarations();

            // NewingDataTypes();

            // ObjectFunctionality();

            // DataTypeFunctionality();

            BasicSringFunctionality();
        }

        private static void GetUserData()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();
            // Chnage echo color
            ConsoleColor prebackColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            // Echo to console
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            // Revert the color changes
            Console.ForegroundColor = prevColor;
            Console.BackgroundColor = prebackColor;
            Console.WriteLine("Thank you!");
        }

        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats: ");

            Console.WriteLine("c format: {0:c}", 99999); // Currency
            Console.WriteLine("d9 format: {0:d9}", 99999); // Decimal, padded
            Console.WriteLine("f3 format: {0:f3}", 99999); // Fixed-point, 3 decimals
            Console.WriteLine("n format: {0:n}", 99999); // Number with commas
            Console.WriteLine("E format: {0:E}", 99999); // Scientific (uppercase E)
            Console.WriteLine("e format: {0:e}", 99999); // Scientific (lowercase e)
            Console.WriteLine("X format: {0:X}", 99999); // Hex, uppercase
            Console.WriteLine("x format: {0:x}", 99999); // Hex, lowercase
        }

        private static void LocalVarDeclarations()
        {
            // Local variables are declared and initialized as follows:
            // dataType varName = initialValue;
            int myInt = 0;

            string myString;
            myString = "This is my character data";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Very verbose manner to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);
            //Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}"
            //                            myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("===> Using new to create variables: ");
            bool b = new bool();            // set to false
            int i = new int();              // set to 0
            double d = new double();        // set to 0
            DateTime dt = new DateTime();   // set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("===> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32.
            // which inherits the following members from System.Object.

            int x = 12;
            Console.WriteLine("X variable contains {0}", x);
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();

            byte a = 0;
            int y = 10;
            Console.WriteLine(a * y);
        }

        static void DataTypeFunctionality()
        {
            double a = -10;
            double b = 0;
            double ans = a / b;

            Console.WriteLine(ans);

            Console.WriteLine("===> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine("bool.sizeof: {0}", sizeof(bool));

            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);


            Console.WriteLine();
        }

        static void BasicSringFunctionality()
        {
            Console.WriteLine("==> Basic String Functionality: ");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in Uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in Lowercase: {0]", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {o}", firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
    }
}