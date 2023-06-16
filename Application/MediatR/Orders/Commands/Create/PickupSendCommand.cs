using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Orders.Commands.Create
{
    public class PickupSendCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }

    public class PickupSendCommandHandler : IRequestHandler<PickupSendCommand, Result>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public PickupSendCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<Result> Handle(PickupSendCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var order = _context.Orders.FirstOrDefault(x => x.Id == request.Id);
                order.OrderStatus = OrderStatus.Done;

                _context.Orders.Update(order);
                await _context.SaveChangesAsync(cancellationToken);

                return Result.Success("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }
    }
}
