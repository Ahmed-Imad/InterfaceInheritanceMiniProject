namespace InterfaceInheritanceMiniProject
{
    public partial class Program
    {
        public interface IInventoryItem
        {
            string ProductName { get; set; }
            int QuantityInStock { get; set; }
        }
    }
}
