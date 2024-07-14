using CarRental.DAL.Context;
using CarRental.Patterns.CQRS.Results.BrandResults;

namespace CarRental.Patterns.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly CarContext _context;

        public GetBrandQueryHandler(CarContext context)
        {
            _context = context;
        }

        public List<GetBrandQueryResult> Handle()
        {
            return _context.Brands.Select(x=>new GetBrandQueryResult
            {
                BrandId = x.BrandId,
                BrandName = x.BrandName
            }).ToList();
        }
    }
}
