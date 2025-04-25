using DesignPattern.Mediator.DataAccessLayer;
using DesignPattern.Mediator.MediatorPattern.Commands;
using DesignPattern.Mediator.MediatorPattern.Queries;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductID);
            values.ProductName = request.ProductName;
            values.ProductStock = request.ProductStock;
            values.ProductStockType = request.ProductStockType;
            values.ProductPrice = request.ProductPrice;
            values.ProductCategory = request.ProductCategory;
            await _context.SaveChangesAsync();
        }
    }
}
