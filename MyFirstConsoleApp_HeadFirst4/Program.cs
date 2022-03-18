using System;

namespace MyFirstConsoleApp_HeadFirst4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello again from inside my first console app!");
            Console.WriteLine("Ha ja");
            Console.Beep();
            // this is a comment

            /*
             this is a multi
             line comment
             */

            // the next line gets rid off debug info following the output...comment it out to see the diffirence
            Console.ReadKey();
        }
    }
}
