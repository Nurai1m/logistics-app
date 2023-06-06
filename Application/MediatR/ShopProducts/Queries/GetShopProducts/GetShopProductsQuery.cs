using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.ShopProducts.Queries
{
    public class GetShopProductsQuery : IRequest<List<ShopProductViewDto>>
    {
    }

    public class GetShopProductsQueryHandler : IRequestHandler<GetShopProductsQuery, List<ShopProductViewDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public GetShopProductsQueryHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<ShopProductViewDto>> Handle(GetShopProductsQuery request, CancellationToken cancellationToken)
        {
            var shopsIds = _context.UserShops.Where(x => x.UserId == _userService.Id).Select(x => x.ShopId).ToList();

            var shopProducts = _context.ShopProducts
                .Include(x => x.Product)
                .Include(x => x.Shop)
                .Where(x => shopsIds.Contains(x.ShopId));

            var shopProductDtos = shopProducts.Select(x => new ShopProductViewDto
            {
                ShopName = x.Shop.Name,
                ProductName = x.Product.Name,
                Amount = x.Amount
            }).ToList();

            return shopProductDtos;
        }
    }
}
