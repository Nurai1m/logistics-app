using Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.ProductDictionary.Queries
{
    public class GetProductsQuery : IRequest<List<ProductDto>>
    {
    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public GetProductsQueryHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _context.ProductDictionary.ToList();

            List<ProductDto> productDtos = products.Select(x =>
            new ProductDto
            {
                Name = x.Name,
                Description = x.Description,
                VendorCode = x.VendorCode,
            }).ToList();

            return productDtos;
        }
    }
}
