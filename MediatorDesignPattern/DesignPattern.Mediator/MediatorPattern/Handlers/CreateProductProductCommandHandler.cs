
using DesignPattern.Mediator.DataAccessLayer;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class CreateProductProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType,
                ProductPrice = request.ProductPrice,
                ProductCategory = request.ProductCategory
            });
            await _context.SaveChangesAsync();
        }
    }
}
