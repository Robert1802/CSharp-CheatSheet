using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C14_Methods_Parameters
    {
        // Parameters and Arguments

        // Information can be passed to methods as parameter
        // Parameters act as variables inside the method.
        // They are specified after the method name, inside the parentheses.
        // You can add as many parameters as you want, just separate them with a comma.
        // The following example has a method that takes a string called fname as parameter.

        // When the method is called, we pass along a first name, which is used inside the method to print the full name:
        static void MyMethod(string firstName)
        {
            Console.WriteLine(firstName + " Moura");
        }

        static void Class()
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }

        // Liam Refsnes
        // Jenny Refsnes
        // Anja Refsnes

        // When a parameter is passed to the method, it is called an argument.
        // So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.


        // Multiple Parameters

        // You can have as many parameters as you like, just separate them with commas:
        static void MyMethodWithParameters(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void ClassTwo()
        {
            MyMethodWithParameters("Liam", 5);
            MyMethodWithParameters("Jenny", 8);
            MyMethodWithParameters("Anja", 31);
        }

        // Liam is 5
        // Jenny is 8
        // Anja is 31


        // Default Parameter Value
        // You can also use a default parameter value, by using the equals sign(=).
        // If we call the method without an argument, it uses the default value("Norway") :

        static void MethodWithDefaultParameter(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void ClassThree()
        {
            MethodWithDefaultParameter("Sweden");
            MethodWithDefaultParameter("India");
            MethodWithDefaultParameter();
            MethodWithDefaultParameter("USA");
        }

        // Sweden
        // India
        // Norway
        // USA


        // Return Values

        // In the previous page, we used the void keyword in all examples, which indicates that the method should not return a value.
        // If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:

        static int MethodWithReturnValue(int x)
        {
            return 5 + x;
        }

        static void ClassFour()
        {
            Console.WriteLine(MethodWithReturnValue(3));
        }

        // Outputs 8 (5 + 3)

        // This example returns the sum of a method's two parameters:

        static int MethodWithTwoParameters(int x, int y)
        {
            return x + y;
        }

        static void ClassFive()
        {
            Console.WriteLine(MethodWithTwoParameters(5, 3));
        }

        // Outputs 8 (5 + 3)
        
        // You can also store the result in a variable (recommended, as it is easier to read and maintain):

        static int MethodIntoAVariable(int x, int y)
        {
            return x + y;
        }

        static void ClassSix()
        {
            int z = MethodIntoAVariable(5, 3);
            Console.WriteLine(z);
        }

        // Outputs 8 (5 + 3)


        // Named Arguments

        // It is also possible to send arguments with the key: value syntax.
        // That way, the order of the arguments does not matter:


        static void MethodWithParametersWithKeyValue(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void ClassSeven()
        {
            MethodWithParametersWithKeyValue(child3: "John", child1: "Liam", child2: "Liam");
        }

        // The youngest child is: John
    }
}
