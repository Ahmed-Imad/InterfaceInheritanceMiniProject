using System;

namespace InterfaceInheritanceMiniProject
{
    public partial class Program
    {
        public class VehicleModel : InventoryItemModel, IRentable, IPruchasble
        {
            public decimal DealerFee { get; set; }

            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine("a vehicle has been purchased.");
            }

            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("a vehicle has been rented");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("a vehicle has been returned.");
            }
        }
    }
}
