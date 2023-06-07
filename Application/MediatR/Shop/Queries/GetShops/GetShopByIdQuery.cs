using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Shop.Queries.GetShops
{
    public class GetShopByIdQuery : IRequest<ShopDto>
    {
        public Guid Id { get; set; }
    }

    public class GetShopByIdQueryHandler : IRequestHandler<GetShopByIdQuery, ShopDto>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public GetShopByIdQueryHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<ShopDto> Handle(GetShopByIdQuery request, CancellationToken cancellationToken)
        {
            var shop = _context.UserShops.Include(x => x.Shop).FirstOrDefault(x => x.Shop.Id == request.Id);

            var shopDto =
                new ShopDto
                {
                    Id = shop.Shop.Id,
                    Name = shop.Shop.Name,
                    Description = shop.Shop.Description,
                    Url = shop.Shop.Url
                };

            return shopDto;
        }
    }
}
