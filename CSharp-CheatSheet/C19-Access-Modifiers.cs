using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C19_Access_Modifiers
    {
        // Access Modifiers

        // By now, you are quite familiar with the public keyword that appears in many of our examples:

        public string? color;

        /* The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

        C# has the following access modifiers:

        Modifier    Description
        public      The code is accessible for all classes
        private     The code is only accessible within the same class
        protected   The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
        internal    The code is only accessible within its own assembly, but not from another assembly.You will learn more about this in a later chapter
        There's also two combinations: protected internal and private protected.

        For now, lets focus on public and private modifiers. */

        // Private Modifier --------------------
        // If you declare a field with a private access modifier, it can only be accessed within the same class:

        class PrivateCar
        {
            private string model = "Mustang";
        }

        class Program
        {
            public void Class()
            {
                PrivateCar myObject = new PrivateCar();
                Console.WriteLine(myObject.model); // <<<<< Cannot access object outside the class PrivateCar
            }
        }

        // Public Modifier --------------------
        // If you declare a field with a public access modifier, it is accessible for all classes:

        class PublicCar
        {
            public string model = "Mustang";
        }

        class Program2
        {
            static void Class()
            {
                PublicCar myObject = new PublicCar();
                Console.WriteLine(myObject.model); // Can access object outside the Class PublicCar
            }
        }
    }
}
