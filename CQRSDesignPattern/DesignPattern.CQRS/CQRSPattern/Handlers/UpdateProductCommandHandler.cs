using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Description = command.Description;
            values.Price = command.Price;
            values.ProductID = command.ProductID;
            values.Stock = command.Stock;
            values.Status = true;
            _context.SaveChanges();
        }
    }
}
