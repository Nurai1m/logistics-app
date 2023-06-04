using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;

namespace Application.MediatR.ShopProducts.Commands
{
    public class AddShopProductCommand : IRequest<Result>
    {
        public List<ShopProductDto> ShopProducts { get; set; }
    }

    public class AddShopProductCommandHandler : IRequestHandler<AddShopProductCommand, Result>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public AddShopProductCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<Result> Handle(AddShopProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var shopProducts = request.ShopProducts.Select(x => new ShopProduct
                {
                    ProductId = x.ProductId,
                    ShopId = x.ShopId,
                    Amount = x.Amount,
                });

                _context.ShopProducts.AddRange(shopProducts);
                await _context.SaveChangesAsync(cancellationToken);

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }
    }
}