using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C11_Break_Continue
    {
        public void Class()
        {
            // C# Break and Continue

            // C# Break
            // You have already seen the break statement, it was used to "jump out" of a switch statement
            // The break statement can also be used to jump out of a loop.

            // This example jumps out of the loop when i is equal to 4:
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            // C# Continue
            // The continue statement breaks one iteration(in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

            // This example skips the value of 4:
            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                {
                    continue;
                }
                Console.WriteLine(j);
            }


            // Break and Continue in While Loop
            // You can also use break and continue in while loops:

            // Break Example
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }

            // Continue Example
            int j = 0;
            while (j < 10)
            {
                if (j == 4)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
