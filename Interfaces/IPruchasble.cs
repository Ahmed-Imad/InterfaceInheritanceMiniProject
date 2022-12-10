namespace InterfaceInheritanceMiniProject
{
    public partial class Program
    {
        public interface IPruchasble : IInventoryItem
        {
            void Purchase();
        }
    }
}
