using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C06_Booleans
    {
        public void Class()
        {
            //  C# Booleans
            //  Very often, in programming, you will need a data type that can only have one of two values, like:

            //  YES / NO
            //  ON / OFF
            //  TRUE / FALSE
            //  For this, C# has a bool data type, which can take the values true or false.

            //  Boolean Values
            //  A boolean type is declared with the bool keyword and can only take the values true or false:

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            // Boolean Expression
            // A Boolean expression returns a boolean value: True or False, by comparing values / variables.
            // This is useful to build logic, and find answers.

            // For example, you can use a comparison operator, such as the greater than(>) operator to find out if an expression(or a variable) is true:
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // returns True, because 10 is higher than 9
            // Or even easier:
            Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9

            // In the examples below, we use the equal to(==) operator to evaluate an expression:
            int x2 = 10;
            Console.WriteLine(x2 == 10); // returns True, because the value of x is equal to 10
            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            // Real Life Example
            // Let's think of a "real life example" where we need to find out if a person is old enough to vote.
            // In the example below, we use the >= comparison operator to find out if the age(25) is greater than OR equal to the voting age limit, which is set to 18:
            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);

        }
    }
}
