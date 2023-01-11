
namespace CSharp_CheatSheet
{
    internal class C02_Data_Type
    {
        public void Class()
        {
            // -------------------------------------------------------------------------------------------------------------

            // Data Types
            // A variable in C# must be a specified data type:

            // int myNum = 5;               // Integer (whole number)   // Stores whole numbers from -2,147,483,648 to 2,147,483,647
            // double myDoubleNum = 5.99D;  // Floating point number    // Stores fractional numbers. Sufficient for storing 15 decimal digits
            // char myLetter = 'D';         // Character                // Stores a single character/letter, surrounded by single quotes
            // bool myBool = true;          // Boolean                  // Stores true or false values
            // string myText = "Hello";     // String                   // Stores a sequence of characters, surrounded by double quotes

            // -------------------------------------------------------------------------------------------------------------

            // Type Casting

            // Type casting is when you assign a value of one data type to another type.
            // In C#, there are two types of casting:

            // Implicit Casting(automatically) -converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            // Explicit Casting(manually) - converting a larger type to a smaller size type
            // double -> float -> long -> int -> char

            // Implicit Casting is done automatically when passing a smaller size type to a larger size type:

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit Casting must be done manually by placing the type in parentheses in front of the value:

            double myNewDouble = 9.78;
            int myNewInt = (int)myNewDouble;    // Manual casting: double to int

            Console.WriteLine(myNewDouble);   // Outputs 9.78
            Console.WriteLine(myNewInt);      // Outputs 9

            // Type Conversion Methods
            // It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long):

            int myIntVariable = 10;
            double myDoubleVariable = 5.25;
            bool myBoolVariable = true;

            Console.WriteLine(Convert.ToString(myIntVariable));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntVariable));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleVariable));  // convert double to int
            Console.WriteLine(Convert.ToString(myBoolVariable));   // convert bool to string

            // -------------------------------------------------------------------------------------------------------------

            // Get User Input
            // You have already learned that Console.WriteLine() is used to output(print) values.Now we will use Console.ReadLine() to get user input.
            // In the following example, the user can input his or hers username, which is stored in the variable userName.Then we print the value of userName:

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            // The Console.ReadLine() method returns a string.
            // Therefore, you cannot get information from another data type, such as int
            // Cannot implicitly convert type 'string' to 'int'

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }
}
