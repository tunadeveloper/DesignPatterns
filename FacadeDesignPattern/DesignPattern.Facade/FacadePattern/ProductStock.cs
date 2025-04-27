using DesignPattern.Facade.DataAccessLayer;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context context = new Context();
        public void StockDecrease(int id, int amount)
        {
            var value = context.Products.Find(id);
            value.ProductStock -= amount;
            context.SaveChanges();
        }
    }
}
