using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharp_CheatSheet
{
    internal class C12_Arrays
    {
        public void Class()
        {
            // C# Arrays

            // Create an Array
            // Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

            // To declare an array, define the variable type with square brackets:
            string[] cars;
            // We have now declared a variable that holds an array of strings.

            // To insert values to it, we can use an array literal -place the values in a comma-separated list, inside curly braces:
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };

            // To create an array of integers, you could write:
            int[] myNum = { 10, 20, 30, 40 };


            // Add Element to an Array using Append()
            // To add another element at the end of the array
            int[] myNumArr = { 10, 20, 30, 40 };
            myNumArr = myNumArr.Append(50).ToArray();


            // Add Element to an Array using List.Add()
            // New String Array with a few default values
            string[] colorsArray = new string[] { "Red", "Blue" };
            // Convert Array To List
            var colorsList = colorsArray.ToList();
            // Add Item To List
            colorsList.Add("White");
            // Convert back to List
            colorsArray = colorsList.ToArray();


            // Access the Elements of an Array
            // You access an array element by referring to the index number.
            // This statement accesses the value of the first element in cars:
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars3[0]); // Outputs Volvo
                                         // Note: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

            // Change an Array Element
            // To change the value of a specific element, refer to the index number:
            cars3[0] = "Opel";
            // Example
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
            cars4[0] = "Opel";
            Console.WriteLine(cars4[0]); // Now outputs Opel instead of Volvo


            // Array Length
            // To find out how many elements an array has, use the Length property:
            string[] cars5 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars5.Length); // Outputs 4


            // Other Ways to Create an Array
            // If you are familiar with C#, you might have seen arrays created with the new keyword,
            // and perhaps you have seen arrays with a specified size as well.
            // In C#, there are different ways to create an array:

            // Create an array of four elements, and add values later
            string[] cars6 = new string[4];
            // Create an array of four elements and add values right away 
            string[] cars7 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements without specifying the size 
            string[] cars8 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars9 = { "Volvo", "BMW", "Ford", "Mazda" };

            // It is up to you which option you choose.The last option is faster and easier to read.
            // However, you should note that if you declare an array and initialize it later, you have to use the new keyword:
            // Declare an array
            string[] cars10;
            // Add values, using new
            cars10 = new string[] { "Volvo", "BMW", "Ford" };
            // Add values without using new (this will cause an error)
            cars10 = { "Volvo", "BMW", "Ford"};


            // Loop Through an Array
            // You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

            // The following example outputs all elements in the cars array:
            string[] cars11 = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars11.Length; i++)
            {
                Console.WriteLine(cars11[i]);
            }


            // The foreach Loop
            // There is also a foreach loop, which is used exclusively to loop through elements in an array:
            // Syntax
            foreach (type variableName in arrayName)
            {
                // code block to be executed
            }

            // The following example outputs all elements in the cars array, using a foreach loop:
            string[] cars12 = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars12)
            {
                Console.WriteLine(car);
            }
            // The example above can be read like this: for each string element(called car - as in index) in cars, print out the value of car.
            // If you compare the for loop and foreach loop, you will see that the foreach method is easier to write,
            // it does not require a counter(using the Length property), and it is more readable.

            // ----------------------

            // Sort an Array
            //There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:

            // Sort a string
            string[] cars13 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars13);
            foreach (string car in cars13)
            {
                Console.WriteLine(car);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            // ----------------------

            // System.Linq Namespace
            // Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
            //      using System;
            //      using System.Linq;
            int[] myNumbersWithLinq = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbersWithLinq.Max());  // returns the largest value
            Console.WriteLine(myNumbersWithLinq.Min());  // returns the smallest value
            Console.WriteLine(myNumbersWithLinq.Sum());  // returns the sum of elements

            // ----------------------

            // Multidimensional Arrays

            // If you want to store data as a tabular form, like a table with rows and columns, you need to get familiar with multidimensional arrays.
            // A multidimensional array is basically an array of arrays.
            // Arrays can have any number of dimensions.The most common are two - dimensional arrays(2D).

            // Two - Dimensional Arrays
            // To create a 2D array, add each array within its own set of curly braces, and insert a comma(,) inside the square brackets:
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            // Good to know: The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].

            /* [row, column]
                 -      |   COLUMN 0    | COLUMN 1  | COLUMN 2
                ROW 0   |      1        |    4      |    2
                ROW 1   |      3        |    6      |    8

            numbers is now an array with two arrays as its elements.
            The first array element contains three elements: 1, 4 and 2, while the second array element contains 3, 6 and 8.
            To visualize it, think of the array as a table with rows and columns:
             */


            // Access Elements of a 2D Array
            // To access an element of a two - dimensional array, you must specify two indexes:
            //      one for the array, and one for the element inside that array.
            // Or better yet, with the table visualization in mind;
            //      one for the row and one for the column (see example below).

            // This statement accesses the value of the element in the first row(0) and third column(2) of the numbers array:
            int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers2[0, 2]);  // Outputs 2
                                                // Remember that: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.


            // Change Elements of a 2D Array
            // You can also change the value of an element.

            // The following example will change the value of the element in the first row(0) and first column(0):
            int[,] numbers3 = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers3[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers3[0, 0]); // Outputs 5 instead of 1


            // Loop Through a 2D Array
            // You can easily loop through the elements of a two - dimensional array with a foreach loop:
            int[,] numbers4 = { { 1, 4, 2 }, { 3, 6, 8 } };
            foreach (int number in numbers4)
            {
                Console.WriteLine(number);
            }

            // You can also use a for loop.For multidimensional arrays, you need one loop for each of the array's dimensions.
            // Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:
            int[,] numbers5 = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers5.GetLength(0); i++)
            {
                for (int j = 0; j < numbers5.GetLength(1); j++)
                {
                    Console.WriteLine(numbers5[i, j]);
                }
            }

        }
    }
}
