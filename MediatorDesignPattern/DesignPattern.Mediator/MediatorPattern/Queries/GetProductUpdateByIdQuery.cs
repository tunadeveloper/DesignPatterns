using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery:IRequest<UpdateProductByIdQueryResult>
    {
        public int ProductID { get; set; }
        public GetProductUpdateByIdQuery(int productId)
        {
            ProductID = productId;
        }
    }
}
