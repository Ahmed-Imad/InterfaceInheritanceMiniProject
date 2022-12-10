using System;

namespace InterfaceInheritanceMiniProject
{
    public partial class Program
    {
        public class ExcavatorModel : InventoryItemModel, IRentable
        {
            public void Dig()
            {
                Console.WriteLine("Excavator is diging!");
            }

            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("This excavator has been rented.");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("This excavator has been returned.");
            }
        }
    }
}
