using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C07_If_Else
    {
        public void Class()
        {
            //C# If ... Else

            /*C# Conditions and If Statements supports the usual logical conditions from mathematics:
                - Less than: a < b
                - Less than or equal to: a <= b
                - Greater than: a > b
                - Greater than or equal to: a >= b
                - Equal to a == b
                - Not Equal to: a != b
            You can use these conditions to perform different actions for different decisions.

            C# has the following conditional statements:
                - Use if to specify a block of code to be executed, if a specified condition is true
                - Use else to specify a block of code to be executed, if the same condition is false
                - Use else if to specify a new condition to test, if the first condition is false
                - Use switch to specify many alternative blocks of code to be executed
            */

            // The if Statement --------------------------------------------------------------------------------

            // Use the if statement to specify a block of C# code to be executed if a condition is True.

            //Syntax
            if (condition)
            {
                block of code to be executed if the condition is True
            }
            // Note that if is in lowercase letters. Uppercase letters(If or IF) will generate an error.

            // In the example below, we test two values to find out if 20 is greater than 18.If the condition is True, print some text:
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            // We can also test variables:
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            // In the example above we use two variables, x and y, to test whether x is greater than y(using the > operator).
            // As x is 20, and y is 18, and we know that 20 is greater than 18, we print to the screen that "x is greater than y".

            // The else Statement --------------------------------------------------------------------------------

            // Use the else statement to specify a block of code to be executed if the condition is False.

            // Syntax
            if (condition)
            {
                // block of code to be executed if the condition is True
            }
            else
            {
                // block of code to be executed if the condition is False
            }

            // Example
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
            // In the example above, time (20) is greater than 18, so the condition is False.Because of this,
            // we move on to the else condition and print to the screen "Good evening".
            // If the time was less than 18, the program would print "Good day".

            // C# The else if Statement --------------------------------------------------------------------------------

            // The else if Statement is use the else if statement to specify a new condition if the first condition is False.

            // Syntax
            if (condition1)
            {
                // block of code to be executed if condition1 is True
            }
            else if (condition2)
            {
                // block of code to be executed if the condition1 is false and condition2 is True
            }
            else
            {
                // block of code to be executed if the condition1 is false and condition2 is False
            }
            
            // Example
            int time2 = 22;
            if (time2 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time2 < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
            // In the example above, time (22) is greater than 10, so the first condition is False.The next condition, in the else if statement, is also False, so we move on to the else condition since condition1 and condition2 is both False - and print to the screen "Good evening".
            // However, if the time was 14, our program would print "Good day."

            // Ternary Operator (Short Hand If...Else)
            // There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements:

            // Syntax
            variable = (condition) ? expressionTrue : expressionFalse;
            
            // Instead of writing:
            int time3 = 20;
            if (time3 < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // You can simply write:
            int time4 = 20;
            string result = (time4 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


        }
    }
}
