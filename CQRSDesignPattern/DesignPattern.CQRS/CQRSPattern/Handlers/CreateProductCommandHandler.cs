using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }


        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Price = command.Price,
                Description = command.Description,
                Status = true,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
