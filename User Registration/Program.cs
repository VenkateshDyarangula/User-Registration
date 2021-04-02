using System;


namespace UC3_Valid_Email
{
    class Program
    {

        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidFirstName("Venky"));
            Console.WriteLine(pattern.isValidLastName("Dyarangula"));
            Console.WriteLine(pattern.isValidEmail("BridgeLabs123@gmail.co.in"));

        }

    }
}
