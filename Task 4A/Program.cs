using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program
{
    public static void program()
    {

        Console.Write("Please enter a number to divide 100: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            int result = 100 / num;
            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by 0");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("What are you trying to cast? It should be a number...");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Invalid operation"); // how are you supposed to get this?
        }
        catch (FormatException)
        {
            Console.WriteLine("Please do not leave the input empty");
        }
        catch (OverflowException)
        {
            Console.WriteLine("maybe your number is a bit too big");
        }
        catch (Exception e)
        {
            Console.WriteLine("How did you get here? Seriously... \n Your error is: " + e);
        }
        finally
        {
            Console.WriteLine("Run me again :)");
        }
    }

    public static void Main()
    {
        program();
    }
}
