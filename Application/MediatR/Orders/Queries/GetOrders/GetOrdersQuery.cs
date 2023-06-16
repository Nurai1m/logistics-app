using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Orders.Queries
{
    public class GetOrdersQuery : IRequest<List<OrderDto>>
    {
    }

    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, List<OrderDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public GetOrdersQueryHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<OrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var userShopIds = _context.UserShops.Where(x => x.UserId == _userService.Id).Select(x => x.ShopId).ToList();

                var orders = _context.Orders
                    .Include(x => x.Shop)
                    .Include(x => x.Сarrier)
                    .Include(x => x.Customer)
                    .Where(x => userShopIds.Contains(x.ShopId)).ToList();

                var orderDtos = orders.Select(x => new OrderDto
                {
                    Id = x.Id,
                    DeliveryType = x.DeliveryType,
                    CustomerName = x.Customer.Fullname,
                    CarrierName = x.Сarrier != null ? x.Сarrier.Fullname : null,
                    TreckingNumber = x.TreckingNumber,
                    Address = x.Address,
                    Description = x.Description,
                    OrderStatus = x.OrderStatus,
                })
                    .ToList();

                return orderDtos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
