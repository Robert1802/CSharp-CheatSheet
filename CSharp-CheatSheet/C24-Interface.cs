using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C24_Interface
    {
        // Interfaces
        
        // Another way to achieve abstraction in C#, is with interfaces.
        // An interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies) :

        // interface
        interface AnimalExample
        {
            void animalSound(); // interface method (does not have a body)
            void run(); // interface method (does not have a body)
        }

        // It is considered good practice to start with the letter "I" at the beginning of an interface,
        // as it makes it easier for yourself and others to remember that it is an interface and not a class.
        // By default, members of an interface are abstract and public.
        // Note: Interfaces can contain properties and methods, but not fields.

        // To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class.
        // To implement an interface, use the : symbol (just like with inheritance).
        // The body of the interface method is provided by the "implement" class.
        // Note that you do not have to use the override keyword when implementing an interface:

        // Interface
        interface IAnimal
        {
            void animalSound(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        class Pig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Program
        {
            static void Class()
            {
                Pig myPig = new Pig();  // Create a Pig object
                myPig.animalSound();
            }
        }

        // Notes on Interfaces:
        //      - Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
        //      - Interface methods do not have a body - the body is provided by the "implement" class
        //      - On implementation of an interface, you must override all of its methods
        //      - Interfaces can contain properties and methods, but not fields/variables
        //      - Interface members are by default abstract and public
        //      - An interface cannot contain a constructor(as it cannot be used to create objects)


        // Why And When To Use Interfaces?
        //  1) To achieve security - hide certain details and only show the important details of an object (interface).
        //  2) C# does not support "multiple inheritance" (a class can only inherit from one base class).
        //  However, it can be achieved with interfaces, because the class can implement multiple interfaces.
        //  Note: To implement multiple interfaces, separate them with a comma (see example below).


        // Multiple Interfaces
        // To implement multiple interfaces, separate them with a comma:

        interface IFirstInterface
        {
            void myMethod(); // interface method
        }

        interface ISecondInterface
        {
            void myOtherMethod(); // interface method
        }

        // Implement multiple interfaces
        class DemoClass : IFirstInterface, ISecondInterface
        {
            public void myMethod()
            {
                Console.WriteLine("Some text..");
            }
            public void myOtherMethod()
            {
                Console.WriteLine("Some other text...");
            }
        }

        class Program2
        {
            static void Class()
            {
                DemoClass myObject = new DemoClass();
                myObject.myMethod();
                myObject.myOtherMethod();
            }
        }
    }
}
