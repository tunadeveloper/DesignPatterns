using DesignPattern.Mediator.DataAccessLayer;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, UpdateProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ProductID);
            return new UpdateProductByIdQueryResult
            {
                ProductID = request.ProductID,
                ProductCategory = values.ProductCategory,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType
            };
        }
    }
}
