using System; // This is a namespace that contains the Console class allows us to write to the console using various methods like variable interpolation, string concatenation, etc.

namespace HelloWorld // This is a namespace that contains the Program class. Namespaces are used to organize code and prevent naming conflicts.
{
    class Program // This is a class that contains the Main method. The Main method is the entry point of the program.
    {
        static void Main(string[] args) // This is the entry point of the program. The Main method is the first method that gets called when the program is run.
        {
            Console.WriteLine("Hello My Name Is Shane Cummings!"); // This is a method that writes the string "Hello World!" to the console.
            Console.WriteLine("My Banner ID is B01740631.");
            Console.Write("Press any key to exit...");//writeline is a method that writes a string to the console and moves to the next line, write is a method that writes a string to the console and stays on the same line
            Console.ReadKey(); // This is a method that waits for the user to press a key before exiting the program.
        }
    }
}

// run dotnet build after saving the file, BEFORE you Dotnet run!