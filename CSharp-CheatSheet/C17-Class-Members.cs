using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C17_Class_Members
    {
        // Class Members

        // Fields and methods inside classes are often referred to as "Class Members":
        // Create a Car class with three class members : two fields and one method.

        // The class
        class MyClass
        {
            // Class members
            string color = "red";        // field
            int maxSpeed = 200;          // field
            public void fullThrottle()   // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }
        }

        // Fields ---------------------------------

        // In the previous chapter, you learned that variables inside a class are called fields,
        // and that you can access them by creating an object of the class, and by using the dot syntax(.).
        // The following example will create an object of the Car class, with the name myObject.
        // Then we print the value of the fields color and maxSpeed:

        class Car1
        {
            string color = "red";
            int maxSpeed = 200;

            static void Main(string[] args)
            {
                Car1 myObject = new Car1();
                Console.WriteLine(myObject.color);
                Console.WriteLine(myObject.maxSpeed);
            }
        }

        // You can also leave the fields blank, and modify them when creating the object
        // This is especially useful when creating multiple objects of one class:

        class Car2
        {
            string model;
            string color;
            int year;

            static void Main(string[] args)
            {
                Car2 Ford = new Car2();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1969;

                Car2 Opel = new Car2();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
            }
        }


        // Object Methods

        // You learned from the C# Methods chapter that methods are used to perform certain actions.
        // Methods normally belongs to a class, and they define how an object of a class behaves.
        // Just like with fields, you can access methods with the dot syntax.However, note that the method must be public.
        // And remember that we use the name of the method followed by two parantheses() and a semicolon ; to call(execute) the method:

        class Car3
        {
            string color;                 // field
            int maxSpeed;                 // field
            public void fullThrottle()    // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }

            static void Main(string[] args)
            {
                Car3 myObj = new Car3();
                myObj.fullThrottle();  // Call the method
            }
        }

        // Why did we declare the method as public, and not static?
        // The reason is simple: a static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.


        // Use Multiple Classes
        // Remember from the last chapter, that we can use multiple classes for better organization(one for fields and methods, and another one for execution). This is recommended:


        // Pretend the next two classes are in different files:
        class Car4
        {
            public string model;
            public string color;
            public int year;
            public void fullThrottle()
            {
                Console.WriteLine("The car is going as fast as it can!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car4 Ford = new Car4();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1969;

                Car4 Opel = new Car4();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
            }
        }

        // The "public" keyword is called an access modifier, which specifies that the fields of Car are accessible for other classes as well, such as Program.

    }
}
