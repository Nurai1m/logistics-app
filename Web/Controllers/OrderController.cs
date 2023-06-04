using Application.MediatR.Carrier.Queries;
using Application.MediatR.Clients.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private IMediator Mediator;

        public OrderController(IMediator mediator)
        {
            Mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            ViewData["Carriers"] = await Mediator.Send(new GetCarriersQuery());
            ViewData["Customers"] = await Mediator.Send(new GetClientsQuery());

            return View();
        }
    }
}
