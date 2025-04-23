namespace DesignPattern.Composite.DataAccessLayer
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }

    }
}
