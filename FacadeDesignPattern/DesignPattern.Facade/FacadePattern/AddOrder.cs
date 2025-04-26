using DesignPattern.Facade.DataAccessLayer;

namespace DesignPattern.Facade.FacadePattern
{
    public class AddOrder
    {
        private readonly Context _context;

        public AddOrder(Context context)
        {
            _context = context;
        }

        public void AddNewOrder(Order order)
        {
            order.OrderDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
