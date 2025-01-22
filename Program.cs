using System; // This is a namespace that contains the Console class allows us to write to the console using various methods like variable interpolation, string concatenation, etc.

namespace HelloWorld // This is a namespace that contains the Program class. Namespaces are used to organize code and prevent naming conflicts.
{
    class Program // This is a class that contains the Main method. The Main method is the entry point of the program.
    {
        static void Main(string[] args) // This is the entry point of the program. The Main method is the first method that gets called when the program is run.
        {
            Console.WriteLine("Hello World!"); // This is a method that writes the string "Hello World!" to the console.
        }
    }
}

// run dotnet build after saving the file