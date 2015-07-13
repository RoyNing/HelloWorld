//A Hello World! program in C#.
using System;
namespace HelloWorl
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            //Keep the console widow open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}