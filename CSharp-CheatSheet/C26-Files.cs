using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_CheatSheet
{
    internal class C26_Files
    {
        // Working With Files
        // The File class from the System.IO namespace, allows us to work with files:

        void Class()
        {
            // using System.IO;  // include the System.IO namespace
            File.SomeFileMethod();  // use the file class with methods
        }
        // The File class has many useful methods for creating and getting information about files.For example:

        /*
            Method          Description
            AppendText()    Appends text at the end of an existing file
            Copy()          Copies a file
            Create()        Creates or overwrites a file
            Delete()        Deletes a file
            Exists()        Tests whether the file exists
            ReadAllText()   Reads the contents of a file
            Replace()       Replaces the contents of a file with the contents of another file
            WriteAllText()  Creates a new file and writes the contents to it.If the file already exists, it will be overwritten.
        */

        // For a full list of File methods, go to Microsoft.Net File Class Reference.
        // Write To a File and Read It
        // In the following example, we use the WriteAllText() method to create a file named "filename.txt" and write some content to it.
        // Then we use the ReadAllText() method to read the contents of the file:


        void Class2()
        {
            // using System.IO;  // include the System.IO namespace
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }

        // The output will be: Hello World!
    }
}
