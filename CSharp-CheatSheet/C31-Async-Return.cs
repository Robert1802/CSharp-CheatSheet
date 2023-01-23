using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class CXX_Async_Method_Return
    {
        // Async Method Return Types

        // Methods marked with async in C# must return one of the following:
        //  - Task
        //  - Task<T>
        //  - ValueTask
        //  - ValueTask<T>
        //  - void

        //To be clear, when we say return type we're talking about what comes before the method name in the method signature. For example:

        public static async Task MyMethod(int myParameter)
        {
            ...
        }

        // In the above method signature public, static, and async are all what are called "modifiers".
        // The order of these modifiers is not enforced by the C# compiler, but generally, as a convention,
        // the async modifier is put last, just before the return type, which is Task in this example.
        // It's because of this typical positioning that often an asynchronous method in C# is referred to as being either async void or async Task.
        // The contrast between those two is important, as we'll see next.


        // Why You Should Generally Stick to Task
        // Most of the time, you should just use a return type of Task or Task<T> with async methods.
        // Everything else in the list above is for specific situations that are not very common.
        // If anything, you have a choice between returning Task and returning void.
        // But even that choice is lopsided, heavily favoring the use of Task.
        // Why? If a method returns void, callers of that method are not allowed to await it.
        // And if you don't await a method, execution of the caller may continue before the method completes.
        // Even more problematic is that the caller can't handle exceptions properly when it does not await an async method.
        // There are a few valid reasons for returning void from an async method, but the vast majority of the time you should return a Task so you can await it.


        // When to Use Task, and When to Use Task<T>
        // If choosing between Task and void is easy, choosing between Task and Task<T> is even easier.
        // Use Task<T> when you need to return some information from a method, and Task when you don't.
        // The Task<T> class has a Result property of type T that contains whatever you pass back with return statements in the method.
        // The caller generally retrieves what's stored in the Result property implicitly, through the use of await.

        // For example, the following GetHtml method would return an html string retrieved from a remote server, or null if no url was specified.
        async Task<string> GetHtml(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return null;
            }
            string html = await new HttpClient().GetStringAsync(url);
            return html;
        }

        // One could access the html returned by the above method by explicitly referencing the Result property
        Task<string> myTask = client.GetHtml("http://...");
        await myTask;
        string html = myTask.Result;

        // But normally it is easier and more readable to just access it implicitly in-line via await:
        string html = await GetHtml("http://...");


        // Another way to think about it is that choosing between Task and Task<T> in an async method
        // is analogous to choosing between void and any other type in a synchronous method.
        // For example, the following synchronous methods:
        void DoOperation()
        {
            SomeOperation();
        }

        byte[] GetData()
        {
            return GetData("/path/to/data");
        }

        // ...when "asyncified" with Task.Run, would become:
        async Task DoOperation()
        {
            await Task.Run(SomeOperation);
        }

        async Task<byte[]> GetData()
        {
            return await Task.Run(() => GetData("/path/to/data"));
        }


        // Allowed Parameter Types in Async Methods
        // One of the reasons that Task<T> is needed to pass back data to the caller is that async methods are not allowed to have ref or out parameters.

        // For example, the following would cause a compiler error:
        async Task<bool> TryGetHtml(string url, out string html) // Dont do this

        // That being the case, you can't return data using ref or out parameters.
        // Really the only way to return data from an async method is using Task<T>. But the nice thing is that T can be literally anything. It can be a value type such as int or bool, or any reference type, including collections, arrays, or your own custom class. If you find yourself wanting to return multiple variables from an async method, you can define a class that will contain everything you need and return an instance of that class, or, if that proves inconvenient, you can return a Tuple<T1, T2>. As an example, we could implement what we were attempting earlier with TryGetHtml as follows:

        async Task<(bool, string)> TryGetHtml(string url) // Do this
        {
            if (string.IsNullOrEmpty(url))
            {
                return (false, null);
            }
            string html = await new HttpClient().GetStringAsync(url);
            return (true, html);
        }

        // And we could call such a method using:
        public async Task Class2Async()
        {
            (bool success, string html) = await TryGetHtml("http://...");
            if (success)
            {
              // do something with html
            }
        }

        // You can even return a Task<Task<T>> from an async method, which allows nesting of tasks and is occasionally useful.
        // So don't worry about the inability to use ref and out parameters with async methods.
        // Using Task<T> gives you everything you need!


        // When to Use ValueTask Instead of Task
        // So what about ValueTask and ValueTask<T>?
        // Those two are wrappers around Task and Task<T>, with the distinction that they are defined using a struct instead of a class.
        
        // To understand why that might be useful, keep in mind that a class instance is a reference to data that lives in long-term memory (which must be allocated),
        // while a struct is a value type whose data lives in short-term memory (which does not require allocation).
        // Since long-term memory allocation can be expensive, using a ValueTask can sometimes yield better performance.
        // That said, a ValueTask wraps a Task, so when the ValueTask's Task field is populated, not only does it still involve long-term memory,
        // it also uses more memory overall than a Task by itself, which actually ends up being worse.
        // So it depends very much on the application.

        // The good news is that most developers do not need to concern themselves with the details.
        // The general recommendation is to always use Task or Task<T>,
        // and only consider using ValueTask or ValueTask<T> if profiling your code with a performance analysis tool
        // indicates that the allocations associated with Task are a bottleneck for your particular application.
        // As it turns out, this would only be the case if your code was structured asynchronously,
        // but executes synchronously (due to cached results, or frequent use of methods like Task.FromResult<T> that generate pre-completed Task instances), and does so in tight loops.
        
        // So while it's certainly nice to have ValueTask available just in case, it's unlikely you will ever need it.
        // If you do end up using ValueTask, be sure to read all available documentation carefully, as its behavior can differ from Task in subtle ways.
    }
}
