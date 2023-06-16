using Application.MediatR.Carrier.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CarrierController : Controller
    {
        private IMediator Mediator;

        public CarrierController(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task<IActionResult> Index(GetCarriersQuery query)
        {
            var result = await Mediator.Send(query);
            ViewData["Carriers"] = result;
            return View(query);
        }
    }
}
