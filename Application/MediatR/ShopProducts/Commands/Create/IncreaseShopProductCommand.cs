using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;

namespace Application.MediatR.ShopProducts.Commands
{
    public class IncreaseShopProductCommand : IRequest<Result>
    {
        public List<(Guid, double)> ShopProducts { get; set; }
    }

    public class IncreaseShopProductCommandHandler : IRequestHandler<IncreaseShopProductCommand, Result>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public IncreaseShopProductCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<Result> Handle(IncreaseShopProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var shopProducts = new List<ShopProduct>();
                foreach (var item in request.ShopProducts)
                {
                    var shopProduct = _context.ShopProducts.FirstOrDefault(x => x.Id == item.Item1);
                    shopProduct.Amount = shopProduct.Amount + item.Item2;
                    shopProducts.Add(shopProduct);
                }

                _context.ShopProducts.UpdateRange(shopProducts);
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