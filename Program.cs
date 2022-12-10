using System;
using System.Collections.Generic;
using System.Globalization;

namespace InterfaceInheritanceMiniProject
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPruchasble> pruchasbles = new List<IPruchasble>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "a Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);
            pruchasbles.Add(book);
            pruchasbles.Add(vehicle);
            string input;

            do
            {
                Console.Write("Do you want to rent or purchase something? (rent, purchase): ");
                Console.WriteLine("Please type exit to stop the application!");
                input = Console.ReadLine();

                if (input.ToLower() == "rent")
                {
                    foreach (var item in rentables)
                    {
                        Console.WriteLine($"Item: {item.ProductName}");
                        Console.WriteLine("Do you want to rent this item (yes/no): ");
                        input = Console.ReadLine();
                        if (input.ToLower() == "yes")
                        {
                            item.Rent();
                            Console.WriteLine("you rent it!");
                        }

                        Console.WriteLine($"Item: {item.ProductName}");
                        Console.WriteLine("Do you want to return this item (yes/no): ");
                        input = Console.ReadLine();
                        if (input.ToLower() == "yes")
                        {
                            item.ReturnRental();
                            Console.WriteLine("you return it!");
                        }
                    }
                }

                else if (input.ToLower() == "purchase")
                {
                    foreach (var item in pruchasbles)
                    {
                        Console.WriteLine($"Item: {item.ProductName}");
                        Console.WriteLine("Do you want to purchase this item (yes/no): ");
                        input = Console.ReadLine();
                        if (input.ToLower() == "yes")
                        {
                            item.Purchase();
                            Console.WriteLine("you purchased it, Congratulations!");
                        }                       
                        
                    }
                }
                else if (input.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You input is invalid. Please try again.");

                }
            } while (input.ToLower() != "rent" && input.ToLower() != "purchase");

            Console.WriteLine("We are done!");
            Console.ReadLine();
        }
    }
}
