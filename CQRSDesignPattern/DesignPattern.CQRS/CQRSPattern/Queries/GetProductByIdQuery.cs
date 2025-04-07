using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdQuery
    {
        public int ProductID { get; set; }


        public GetProductByIdQuery(int productID)
        {
            ProductID = productID;
        }
    }
}
