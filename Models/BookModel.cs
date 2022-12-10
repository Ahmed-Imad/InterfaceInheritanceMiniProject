using System;

namespace InterfaceInheritanceMiniProject
{
    public partial class Program
    {
        public class BookModel : InventoryItemModel, IPruchasble
        {
            public int NumberOfPages { get; set; }

            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine("a book has been purchased.");
            }
        }
    }
}
