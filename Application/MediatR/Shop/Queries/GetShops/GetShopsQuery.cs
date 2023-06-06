using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Shop.Queries
{
    public class GetShopsQuery : IRequest<List<ShopDto>>
    {
    }

    public class GetShopsQueryHandler : IRequestHandler<GetShopsQuery, List<ShopDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public GetShopsQueryHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<ShopDto>> Handle(GetShopsQuery request, CancellationToken cancellationToken)
        {
            var shops = _context.UserShops.Include(x => x.Shop).Where(x => x.UserId == _userService.Id).ToList();

            List<ShopDto> shopDtos = shops.Select(x =>
            new ShopDto
            {
                Id = x.Shop.Id,
                Name = x.Shop.Name,
                Description = x.Shop.Description,
                Url = x.Shop.Url
            }).ToList();

            return shopDtos;
        }
    }
}
