using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C18_Constructors
    {
        // C# Constructors

        // A constructor is a special method that is used to initialize objects.
        // The advantage of a constructor, is that it is called when an object of a class is created.It can be used to set initial values for fields:


        // Create a constructor:

        // Create a Car class
        class Car
        {
            public string model;  // Create a field

            // Create a class constructor for the Car class
            public Car()
            {
                model = "Mustang"; // Set the initial value for model
            }

            public void Class()
            {
                Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
                Console.WriteLine(Ford.model);  // Print the value of model
            }
        }

        // Outputs "Mustang"


        // Note that the constructor name must match the class name, and it cannot have a return type(like void or int).
        // Also note that the constructor is called when the object is created.
        // All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.


        // Constructor Parameters

        // Constructors can also take parameters, which is used to initialize fields.
        // The following example adds a string modelName parameter to the constructor.
        // Inside the constructor we set model to modelName (model = modelName).
        // When we call the constructor, we pass a parameter to the constructor("Mustang"), which will set the value of model to "Mustang":


        class Car2
        {
            public string model;

            // Create a class constructor with a parameter
            public Car2(string modelName)
            {
                model = modelName;
            }

            static void Main(string[] args)
            {
                Car2 Ford = new Car2("Mustang");
                Console.WriteLine(Ford.model);
            }
        }

        // Outputs "Mustang"

        // You can have as many parameters as you want:

        class Car3
        {
            public string model;
            public string color;
            public int year;

            // Create a class constructor with multiple parameters
            public Car3(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }

            static void Main(string[] args)
            {
                Car3 Ford = new Car3("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            }
        }


        // Outputs Red 1969 Mustang


        // Tip: Just like other methods, constructors can be overloaded by using different numbers of parameters.

        // Constructors Save Time
        // When you consider the example from the previous chapter, you will notice that constructors are very useful, as they help reducing the amount of code

        // Two examples of a class WITH constructor and WITHOUT constructor

        // WITHOUT CONSTRUCTOR

        class ProgramWithoutConstructor
        {
            static void ClassTest()
            {
                CarNoConstructor Ford = new CarNoConstructor();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1969;

                CarNoConstructor Opel = new CarNoConstructor();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
            }
        }

        // WITH CONSTRUCTOR

        class ProgramWithConstructor
        {
            static void Main(string[] args)
            {
                Car3 Ford = new Car3("Mustang", "Red", 1969);
                Car3 Opel = new Car3("Astra", "White", 2005);

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
            }
        }
    }

    internal class CarNoConstructor
    {
        public string model;
        public string color;
        public int year;
    }

}
