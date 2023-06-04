using Application.MediatR.Clients.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ClientController : Controller
    {
        private IMediator Mediator;

        public ClientController(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task<IActionResult> Index(GetClientsQuery query)
        {
            var result = await Mediator.Send(query);
            ViewData["Shops"] = result;
            return View(query);
        }
    }
}
