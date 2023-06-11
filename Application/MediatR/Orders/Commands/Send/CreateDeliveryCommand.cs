using Application.Common.Algorithms.AStarAlgorithmWithListVisit;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
                var startLocation = _context.ShopLocations.FirstOrDefault(x => x.Id == orders.FirstOrDefault().ShopLocationId);

                double.TryParse(startLocation.Lat, out double lat);
                double.TryParse(startLocation.Lang, out double lang);

                Location start = new Location
                (
                    startLocation.Name,
                    lat,
                    lang
                );

                List<Location> locations = new List<Location>();
                locations.Add(start);
                locations.AddRange(
                    orders.Select(x => new Location
                    (
                        x.TreckingNumber,
                        Convert.ToDouble(x.Lat),
                        Convert.ToDouble(x.Lang)
                    )).ToList());

                

                AStarAlgorithm algorithm = new AStarAlgorithm();
                var result = algorithm.FindShortestPath(locations);

                foreach (var item in result)
                { 
                    Console.WriteLine(item);
                }

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }

        private void GeneratePath()
        {
            AStarAlgorithm algorithm = new AStarAlgorithm();

        }
    }
}
