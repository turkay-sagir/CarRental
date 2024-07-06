namespace CarRental.Patterns.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public int BrandId { get; set; }

        public GetBrandByIdQuery(int brandId)
        {
            BrandId = brandId;
        }
    }
}
