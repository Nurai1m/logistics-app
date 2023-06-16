using Application.Common.Algorithms.AStarAlgorithmWithListVisit2;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Orders.Commands
{
    public class CreateDeliveryCommand : IRequest<List<LocationDto>>
    {
        public List<Guid> OrderIds { get; set; }
    }

    public class CreateDeliveryCommandHandler : IRequestHandler<CreateDeliveryCommand, List<LocationDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public CreateDeliveryCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<LocationDto>> Handle(CreateDeliveryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var orders = _context.Orders.Where(x => request.OrderIds.Contains(x.Id)).ToList();
                var startLocation = _context.ShopLocations.FirstOrDefault(x => x.Id == Guid.Parse("813661c6-33c2-4ca9-8734-ef86477ccca9"));

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

                //var start = new Location("New York", 40.7128, -74.0060);

                //List<Location> locations = new List<Location>
                //{
                //    new Location("Italy", 43.843513, 10.846473),
                //    new Location("Germany", 51.946907, 9.590055),
                //    new Location("Dania", 56.192359, 8.998800),
                //    new Location("Austria", 47.006416, 14.172283),
                //    new Location("France", 48.398955, 4.712199)
                //};


                AStarAlgorithm algorithm = new AStarAlgorithm();
                var result = algorithm.FindShortestPaths(locations);

                //foreach (var item in result)
                //{
                //    var res = item.ShortestDistances.OrderBy(x => x.Value);
                //    Console.WriteLine(item);
                //}

                var resultPath = result.First();

                List<LocationDto> resultLocations = result.First().ShortestDistances.OrderBy(x => x.Value)
                    .Select(x => new LocationDto
                    {
                        Name = x.Key.Name,
                        Lat = x.Key.Latitude.ToString(),
                        Lang = x.Key.Longitude.ToString()
                    }).ToList();

                return resultLocations;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
