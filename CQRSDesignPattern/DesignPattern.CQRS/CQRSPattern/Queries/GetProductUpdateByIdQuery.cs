namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public int ID { get; set; }

        public GetProductUpdateByIdQuery(int id)
        {
            ID = id;
        }
    }
}
