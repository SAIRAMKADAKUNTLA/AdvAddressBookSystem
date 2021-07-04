using System;

namespace AdvAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**WELCOME TO ADDRESSBOOK OPERATION**");
            AdressBookDetails details = new AdressBookDetails();
            details.GetData();
        }
    }
}
