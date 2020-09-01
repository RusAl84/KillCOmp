using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kill your computer");
            int x = 20;
            //
            

                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine("Beep number {0}.", i);
                    Console.Beep();
                }


        }
    }
}
