using System;

namespace StringInterpolationCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine(" String Interpolation Corp");
            Console.WriteLine("     Collections App");
            Console.WriteLine("============================");

            Console.WriteLine("");

            Console.Write("       Name: ");
            string name = Console.ReadLine();

            Console.Write("  Invoice #: ");
            string invoice = Console.ReadLine();

            Console.Write("Amount Owed: ");
            string amount = Console.ReadLine();

            Console.Write("  Date Owed: ");
            string date = Console.ReadLine();                                    

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine($"Dear {name},");
            Console.WriteLine("");

            string message = $"It has come to our attention that you have not submitted ";
            message += $"a payment for invoice {invoice} and your account with String ";
            message += $"Interpolation Corp is in arrears.  Please submit {amount} by ";
            message += $"{date} otherwise we shall taunt you a second time.";
            
            Console.WriteLine(message);                        

            Console.WriteLine("");
            Console.WriteLine("Regards,");
            Console.WriteLine("Bob Tabor");
            Console.WriteLine("Collections Department");
            Console.WriteLine("String Interpolation Corp");

        }
    }
}
