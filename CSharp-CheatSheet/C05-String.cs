using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C05_String
    {
        public void Class()
        {
            // C# Strings
            // Strings are used for storing text.
            // A String variable contains a collection of characters surrounded by double quotes:
            string greeting = "Hello";
            string greeting2 = "Nice to meet you!";

            // String Length
            // A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings.
            // For example, the length of a string can be found with the Length property:
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            // ToUpper() and ToLower()
            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt2.ToLower());   // Outputs "hello world"

            // String Concatenation
            // The + operator can be used between strings to combine them. This is called concatenation:
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name); // John Doe

            // You can also use the string.Concat() method to concatenate two strings:
            string firstName2 = "John ";
            string lastName2 = "Doe";
            string name2 = string.Concat(firstName2, lastName2);
            Console.WriteLine(name2); // John Doe

            // String Interpolation
            // Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string.
            // Note that you do not have to worry about spaces, like with concatenation:
            string firstName3 = "John";
            string lastName3 = "Doe";
            string name3 = $"My full name is: {firstName3} {lastName3}";
            Console.WriteLine(name3); // My full name is: John Doe

            // Access Strings
            // You can access the characters in a string by referring to its index number inside square brackets[].
            // String indexes start with 0: [0] is the first character. [1] is the second character, etc.
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString[1]);  // Outputs "e"

            // You can also find the index position of a specific character in a string, by using the IndexOf() method:
            string myString2 = "Hello";
            Console.WriteLine(myString2.IndexOf("e"));  // Outputs "1"

            // Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/index, and returns a new string.
            // This method is often used together with IndexOf() to get the specific character position:

            // Full name
            string name4 = "John Doe";
            // Location of the letter D
            int charPos = name4.IndexOf("D");
            // Get last name
            string lastName4 = name4.Substring(charPos);
            // Print the result
            Console.WriteLine(lastName4); // Doe

            // Strings - Special Characters
            // Because strings must be written within quotes, C# will misunderstand this string, and generate an error:

            string specialCharacterTxtWrong = "We are the so-called "Vikings" from the north."; // wrong
            
            // The solution to avoid this problem, is to use the backslash escape character.
            // The backslash(\) escape character turns special characters into string characters:

            // The sequence \"  inserts a double quote in a string:
            string specialCharacterTxtRight = "We are the so-called \"Vikings\" from the north."; //right

            //  Escape character    Result  Description
            //  \'	                '       Single quote
            //  \"	                "       Double quote
            //  \\	                \	    Backslash

            // Other useful escape characters in C# are:
            //  Code    Result Try it
            //  \n      New Line
            //  \t      Tab	
            //  \b      Backspace

        }
    }
}
