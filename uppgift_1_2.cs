using System;

namespace Inlamningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue; //färg till blå
            Console.Clear(); 

            Console.ForegroundColor = ConsoleColor.White; //text färg till vit
            
            // texten
            Console.WriteLine("Fatal error: processor meltdown. Please call firefighters for help. Tip: Dont run several programs at once on a pentium 2!");
        }
    }
}