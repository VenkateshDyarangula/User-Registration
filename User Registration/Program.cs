using System;

namespace Valid_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidFirstName("Venky"));
            Console.WriteLine(pattern.isValidFirstName("Dyarangula"));
        }
    }
}
