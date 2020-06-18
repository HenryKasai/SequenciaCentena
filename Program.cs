using System;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("A seguir, os 100 primeiro números não nulos: ");
            int um = 1;
            
            Console.ForegroundColor = ConsoleColor.Green;
            while(um <= 100)
            {
                Console.Write($"{um } ");
                um ++;
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
