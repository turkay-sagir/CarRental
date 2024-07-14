using CarRental.DAL.Context;
using CarRental.Patterns.CQRS.Queries.BrandQueries;
using CarRental.Patterns.CQRS.Results.BrandResults;

namespace CarRental.Patterns.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly CarContext _context;

        public GetBrandByIdQueryHandler(CarContext context)
        {
            _context = context;
        }

        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var value = _context.Brands.Find(query.BrandId);
            return new GetBrandByIdQueryResult
            {
                BrandId = value.BrandId,
                BrandName = value.BrandName
            };
        }
    }
}
