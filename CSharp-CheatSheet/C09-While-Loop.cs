using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C09_While_Loop
    {
        public void CLass()
        {
            // C# While Loop

            // Loops
            // Loops can execute a block of code as long as a specified condition is reached.
            // Loops are handy because they save time, reduce errors, and they make code more readable.

            // C# While Loop
            // The while loop loops through a block of code as long as a specified condition is True:

            // Syntax
            while (condition)
            {
                // code block to be executed
            }
            // In the example below, the code in the loop will run, over and over again, as long as a variable(i) is less than 5:

            // Example
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            // Note: Do not forget to increase the variable used in the condition, otherwise the loop will never end!

            // The Do/ While Loop
            // The do/while loop is a variant of the while loop.
            // This loop will execute the code block once, before checking if the condition is true,
            // then it will repeat the loop as long as the condition is true.

            // Syntax
            do
            {
                // code block to be executed
            }
            while (condition);
            // The example below uses a do/while loop.The loop will always be executed at least once, even if the condition is false,
            // because the code block is executed before the condition is tested:

            // Example
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
            // Note: Do not forget to increase the variable used in the condition, otherwise the loop will never end!
        }
    }
}
