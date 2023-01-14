using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C13_Methods
    {
        // C# Methods
        // A method is a block of code which only runs when it is called.
        // You can pass data, known as parameters, into a method.
        // Methods are used to perform certain actions, and they are also known as functions.
        // Why use methods? To reuse code: define the code once, and use it many times.

        // Create a Method
        // A method is defined with the name of the method, followed by parentheses().
        // C# provides some pre-defined methods, which you already are familiar with, such as Main(),
        // but you can also create your own methods to perform certain actions:

        static void MyMethod()
        {
            // code to be executed
            Console.WriteLine("I just got executed!");
        }

        // Example Explained
        //  - MyMethod() is the name of the method
        //  - static means that the method belongs to the Program class and not an object of the Program class.
        //  - void means that this method does not have a return value.You will learn more about return values later in this chapter
        //  Note: In C#, it is good practice to start with an uppercase letter when naming methods, as it makes the code easier to read.

        // Call a Method
        //To call(execute) a method, write the method's name followed by two parentheses () and a semicolon;
        //In the following example, MyMethod() is used to print a text(the action), when it is called:

        //Example
        //Inside Main(), call the myMethod() method:
        static void Class()
        {
            MyMethod();
        }
        // Outputs "I just got executed!"

        // A method can be called multiple times:
        static void Class2()
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }
        // I just got executed!
        // I just got executed!
        // I just got executed!
    }
}
