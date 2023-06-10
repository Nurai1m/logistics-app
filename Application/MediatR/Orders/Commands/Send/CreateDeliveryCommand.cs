using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Orders.Commands.Send
{
    public class CreateDeliveryCommand : IRequest<Result>
    {
        public List<Guid> OrderIds { get; set; }
    }

    public class CreateDeliveryCommandHandler : IRequestHandler<CreateDeliveryCommand, Result>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public CreateDeliveryCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<Result> Handle(CreateDeliveryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var orders = _context.Orders.Where(x => request.OrderIds.Contains(x.Id)).ToList();


                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }

        private void GeneratePath()
        { 
            
        }
    }
}
