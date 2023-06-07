using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.ShopProducts.Queries.GetShopProducts
{

    public class GetShopProductsByShopIdQuery : IRequest<List<ShopProductViewDto>>
    {
        public Guid ShopId { get; set; }
    }

    public class GetShopProductsQueryHandler : IRequestHandler<GetShopProductsByShopIdQuery, List<ShopProductViewDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public GetShopProductsQueryHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<ShopProductViewDto>> Handle(GetShopProductsByShopIdQuery request, CancellationToken cancellationToken)
        {
            var shopProducts = _context.ShopProducts
                .Include(x => x.Product)
                .Include(x => x.Shop)
                .Where(x => x.ShopId == request.ShopId);

            var shopProductDtos = shopProducts.Select(x => new ShopProductViewDto
            {
                ShopProductId = x.Id,
                ShopId = x.Id,
                ProductId = x.ProductId,
                ShopName = x.Shop.Name,
                ProductName = x.Product.Name,
                Amount = x.Amount
            }).ToList();

            return shopProductDtos;
        }
    }
}
