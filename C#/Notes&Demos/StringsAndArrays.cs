// See https://aka.ms/new-console-template for more information
using System.Text;

namespace FunWithStrings
{
    class Program
    {
        static void Main(String[] args)
        {
            // BasicStringFunctionality();        

            // StringConcatenation();

            // StringsAreImmutable();

            // EscapeChars();

            SimpleArrays();

            ArrayInitialization();

            DeclareImplicitArrays();

            ArrayOfObjects();

            RectMultidimensionalArray();

            JaggedMultidimensionalArray();

            PassAndReceiveArrays();

            SystemArrayFunctionality();

        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("===> String Concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            s2 = s1 + s2;
            Console.WriteLine(s2);
            Console.WriteLine();
        }

        static void StringsAreImmutable()
        {
            Console.WriteLine("===> Strings Are Immutable: ");
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            s1 = s1 + "some more addition to string";
            Console.WriteLine("s1 = {0}", s1);

            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("Upper String = {0}", upperString);

            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);

            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }

        static void EscapeChars()
        {
            Console.WriteLine("===> Escape Characters: \a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a "); //c:\My
            Console.WriteLine("All finished.\n\n\n\\a ");
            Console.WriteLine();

            // The following string is printed verbatim
            // thus, all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            // While space is preserved with verbatim strings.
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);
            Console.WriteLine();
            Console.WriteLine(@"Cerbeus said ""Darr! Pret-ty sun-sets""");
        }

        #region For / foreach loops
        // A basic for loop.
        /*
        static void ForAndForEachLoop()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)//for(;;)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
            Console.WriteLine();
            Excan[] ex = new Excan[4];
            ex[0] = new Excan();
            ex[1] = new Excan(); ex[2] = new Excan(); ex[3] = new Excan();
            ex[0].fname = "Seema";
            ex[1].fname = "Teema";
            ex[2].fname = "Leema";
            ex[3].fname = "Neema";

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(ex[x].fname);
            }

            Console.WriteLine();
            foreach (Excan c in ex)
            { Console.WriteLine(c.fname); }


            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            { Console.WriteLine(c); }
            Console.WriteLine();

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            { Console.WriteLine(i); }

            Console.WriteLine();
        }
        */
        #endregion

        #region Var keyword in foreach
        static void VarInForeachLoop()
        {
            int[] myInts = { 10, 20, 30, 40 };

            // Use "var" in a standard foreach loop.
            foreach (var item in myInts)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine();
        }
        #endregion

        #region while loop
        static void ExecuteWhileLoop()
        {
            string userIsDone = "";

            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }
            Console.WriteLine();
        }
        #endregion

        #region do/while loop
        static void ExecuteDoWhileLoop()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!

            Console.WriteLine();
        }
        #endregion

        #region If/else
        static void ExecuteIfElse()
        {
            // This is illegal, given that Length returns an int, not a bool.
            string stringData = "My textual data";
            if (stringData.Length > 0)
            { Console.WriteLine("string is greater than 0 characters"); }
            else
            { Console.WriteLine("string is not greater than 0 characters"); }
            Console.WriteLine("Hello");
        }
        #endregion

        #region switch statements
        // Switch on a numerical value.
        static void ExecuteSwitch()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();//in.nextInt()
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecuteSwitchOnString()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.WriteLine();
        }

        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
            }
            Console.WriteLine();
        }

        #region Implicit data typing
        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }

        static void ImplicitTypingIsStrongTyping()
        {
            // The compiler knows "s" is a System.String.
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            // Can invoke any member of the underlying type.
            string upper = s.ToUpper();

            // Error! Can't assign numerical data to a a string!
            // s = 44;
        }
        #endregion

        #region Simple Array
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }
        #endregion

        #region Array Init Syntax
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
        #endregion

        #region Var keyword with arrays
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }
        #endregion

        #region Array of objects
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }
        #endregion

        #region MD arrays
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array:\n");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // Populate (3 * 4) array.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array:\n");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is defaulted to zero!)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        #endregion

        #region Arrays as params and return values
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value.
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }
        #endregion

        #region System.Array functionality
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order.
            Console.WriteLine(" -> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Reverse them...
            Array.Reverse(gothicBands);
            Console.WriteLine(" -> The reversed array");
            // ... and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Clear out all but the final member.
            Console.WriteLine(" -> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }
        #endregion
        #endregion
    }
}