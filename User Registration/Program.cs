using System;

namespace UC5_Password_Rule1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter First_Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.isValidFirstName(firstName));
            Console.WriteLine("Enter Last_Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(pattern.isValidLastName(lastName));
            Console.WriteLine("Enter Email_Id:");
            string email = Console.ReadLine();
            Console.WriteLine(pattern.isValidEmail(email));
            Console.WriteLine("Enter Mobile_Number:");
            string mobile = Console.ReadLine();
            Console.WriteLine(pattern.isValidMobileNumber(mobile));
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Console.WriteLine(pattern.isValidPassword(password));

        }
    }
}
