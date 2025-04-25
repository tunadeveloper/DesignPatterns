using DesignPattern.Mediator.DataAccessLayer;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductStock = values.ProductStock
            };
        }
    }
}
