using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C16_OOP
    {
        // C# - What is OOP?

        // OOP stands for Object-Oriented Programming.

        // Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.

        // Object-oriented programming has several advantages over procedural programming:

        //        OOP is faster and easier to execute
        //        OOP provides a clear structure for the programs
        //        OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
        //        OOP makes it possible to create full reusable applications with less code and shorter development time
        //        Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.


        // C# - What are Classes and Objects?

        // Classes and objects are the two main aspects of object-oriented programming.
        //Look at the following comparison to see the difference between class and objects:

        // Example 1
        // class
        //      Fruit

        //  objects
        //      Apple
        //      Banana
        //      Mango


        // Example 2
        //  class
        //      Car

        //  objects
        //      Volvo
        //      Audi
        //      Toyota

        // So, a class is a template for objects, and an object is an instance of a class.
        // When the individual objects are created, they inherit all the variables and methods from the class.
        // Everything in C# is associated with classes and objects, along with its attributes and methods.
        // For example: in real life, a car is an object. The car has attributes, such as weight and color, and methods, such as drive and brake.
        // A Class is like an object constructor, or a "blueprint" for creating objects.

        // Create a Class
        //To create a class, use the class keyword :
        //Create a class named "Car" with a variable color:
        class CarClass
        {
            string color = "red";
        }

        // When a variable is declared directly in a class, it is often referred to as a field(or attribute).
        // It is not required, but it is a good practice to start with an uppercase first letter when naming classes.
        // Also, it is common that the name of the C# file and the class matches, as it makes our code organized.
        // However it is not required (like in Java).

        // Create an Object
        //An object is created from a class. We have already created the class named Car, so now we can use this to create objects.
        //To create an object of Car, specify the class name, followed by the object name, and use the keyword new:

        //Create an object called "myObject" and use it to print the value of color:

        class Car
        {
            string color = "red";

            static void Class()
            {
                Car myObject = new Car();
                Console.WriteLine(myObject.color);
                // Note that we use the dot syntax (.) to access variables/fields inside a class (myObject.color).

                // You can create multiple objects of one class:
                Car myObject1 = new Car();
                Car myObject2 = new Car();
                Console.WriteLine(myObject1.color);
                Console.WriteLine(myObject2.color);
            }
        }

    }
}
