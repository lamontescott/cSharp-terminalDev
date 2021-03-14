using System;

namespace Plain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local Variables
            int num1;
            float f1;
            double d1;
            decimal dec1; //More precise then double and float moves the cursor over to the correct number of positions
            object obj1;
            dynamic dyn1;
            string str1 = "dotnet run";


            Console.WriteLine("Hello World!, this is my first cSharp message");
            Console.WriteLine("Note: To run a cSharp project you must first create a .NET project");
            Console.WriteLine("Type in terminal the command: dotnet new console");
            Console.WriteLine("Click on the Program.cs and start creating file");
            Console.WriteLine($"To run the program type in the command: {str1} in terminal");
        }
    }
}
