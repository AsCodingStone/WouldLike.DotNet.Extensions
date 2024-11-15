using System;
using WouldLike.Extensions;
using WouldLike.Extensions.String;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void Run()
        {
            var myAmazingString = "This is an amazing string";
            Console.WriteLine($"Before: {myAmazingString}");
            var after = myAmazingString.Truncate(7);

            Console.WriteLine($"After: {after}");
        }
    }
}
