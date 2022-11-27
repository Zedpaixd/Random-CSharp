using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public static List<Customer> customers = new List<Customer>();

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

            Customer customer = new Customer(fullname, age, email);
            customers.Add(customer);
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
            try
            {
                using (StreamWriter sw = new StreamWriter("customers.txt"))
                {
                    foreach (Customer cus in customers)
                    {
                        sw.WriteLine(cus.getInfo());
                    }
                }
            }
            catch 
            {
                Console.WriteLine("how do you even get here...?");
            }

            Process.Start("notepad.exe", Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\customers.txt");
        }
    }
}