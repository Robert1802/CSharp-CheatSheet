using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C28_Reflection
    {
        // Reflection provides objects(of type Type) that describe assemblies, modules, and types.
        // You can use reflection to dynamically create an instance of a type, bind the type to an existing object,
        // or get the type from an existing object and invoke its methods or access its fields and properties.
        // If you are using attributes in your code, reflection enables you to access them.For more information, see Attributes.

        void Class()
        {
            // Using GetType to obtain type information:
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);
            // The output is: System.Int32.

            // Using Reflection to get information of an Assembly:
            // using System.Reflection;
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
            // The output is: System.Private.CoreLib, Version = 4.0.0.0, Culture = neutral, PublicKeyToken = 7cec85d7bea7798e.
        }

        // How to use 
        // There are some vectors that use reflection
        // Lets consider this Class

        public class Person
        {
            public string? Name { get; set; }
        }

        void Class2()
        {
            // Lambda expressions
            // This is a reflection vector, as it is possible to use lambda expressions to get to the types,
            // methods and other reflected objects that have been used in the expression.
            // It is commonly used to make obtaining objects reflected from members of a class strongly typed,
            // before that it was only possible to obtain these objects by indicating a string with the name of the method.

            // using System.Linq.Expressions;
            Expression<Func<Person, object>> expr = person => person.Name;
            var lambda = (LambdaExpression)expr;
            UnaryExpression? cast = lambda.Body as UnaryExpression;
            MemberExpression? member = (cast != null ? cast.Operand : lambda.Body) as MemberExpression;
            PropertyInfo? propInfo = member.Member as PropertyInfo;
            Console.WriteLine(propInfo.Name); // "Name"

            // typeof(Tipo)
            // This is one of the most common ways to get information reflected from the system.
            // It serves to get information about the type indicated directly.
            var theType = typeof(Person);
            Console.WriteLine(theType.Name); // "Person"

            // obj.GetType()
            // As common as typeof, but instead of referring to a type directly,
            // refers to the type of the object in question: but it has a detail, it is not the declared type of the variable, but the object itself.
            var person = new Person();
            var theType2 = person.GetType();
            Console.WriteLine(theType2.IsSealed); // "false"

            //Assembly
            // It is used to obtain types on a large scale: for example, to scan all existing types in an assembly, or else in all loaded assemblies.
            // Finding a type among all loaded types
            var allTypesLoaded = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.Name == "Person");
            Console.WriteLine(allTypesLoaded);
        }

        // Reflection overview
        // Reflection is useful in the following situations:
        //  - When you have to access attributes in your program's metadata. For more information, see Retrieving Information Stored in Attributes.
        //  - For examining and instantiating types in an assembly.
        //  - For building new types at run time. Use classes in System.Reflection.Emit.
        //  - For performing late binding, accessing methods on types created at run time.
    }
}
