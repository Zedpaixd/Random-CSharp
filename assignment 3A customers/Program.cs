using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.+]+)@(([[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$"); //abomination
        }

        static bool isName(string strIn)
        {
            return Regex.IsMatch(strIn, "^[A-Za-z ]{3,}$");
        }

        static void CreateCustomer()
        {

            string? fullname,email;
            int age;

            while (true)  // i hate myself for doing it like this
            {
                Console.WriteLine("Input a name: ");
                fullname = Console.ReadLine();
                if (fullname != null && isName(fullname)) break;
                else Console.WriteLine("\nBad name\n");
            }
            while (true)
            {
                Console.WriteLine("Input an age: ");
                try
                {
                    age = int.Parse(Console.ReadLine());
                    if (age < 0) throw new Exception("Age can't be negative");
                    break;
                }
                catch (Exception e)
                { 
                    Console.WriteLine(string.Format("\n{0}\n",e.Message));
                }
            }
            while (true)
            {
                Console.WriteLine("Input an email: ");
                try
                {
                    email = Console.ReadLine();
                    if (!IsValidEmail(email)) throw new Exception("Bad email");
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("\n{0}\n", e.Message));
                }
            }

            Customer custommer = new Customer(fullname, age, email);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hi uh.. what do u wanna do: \n1. Enter customer \n2. Exit\nOption:");
            string? option = Console.ReadLine();
            while (option != "2")
            {
                if (option == "1")
                {
                    CreateCustomer();
                }
                Console.WriteLine("\n What about now? \n1. Enter customer \n2. Exit\nOption:");
                option = Console.ReadLine();
            }
        }
    }
}