using System;


namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter the package Weight:");
            string packWeight = Console.ReadLine();

            if (Convert.ToInt32(packWeight) > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.Have a good day");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter the package width:");
                string packWidth = Console.ReadLine();
                Console.WriteLine("Please enter the package height:");
                string packHeight = Console.ReadLine();
                Console.WriteLine("Please enter the package length:");
                string packLength = Console.ReadLine();
                int totalOfDim = Convert.ToInt32(packHeight) + Convert.ToInt32(packLength) + Convert.ToInt32(packWidth);
                if (totalOfDim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                }
                else
                {
                    double cost = (Convert.ToDouble(packHeight) * Convert.ToDouble(packWidth) * Convert.ToDouble(packLength) * Convert.ToDouble(packWeight)) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:\n\n" + cost + "£\n\nThank you");
                    Console.ReadLine();
                }
            }
        }
    }
}
