using Application.MediatR.Accounts.Commands;
using Application.MediatR.Accounts.Queries.GetRoles;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private IMediator Mediator;

        public AccountController(IMediator mediator)
        { 
            Mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await Mediator.Send(command);
                if (result.Succeed)
                {
                     return RedirectToAction("Index", "Home");
                }
                //foreach (var message in result.Messages) Notyf.Error(message);
            }
            return View(command);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            ViewData["Roles"] = await Mediator.Send(new GetRolesQuery());

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await Mediator.Send(command);
                if (result.Succeed)
                {
                    //foreach (var message in result.Messages) Notyf.Success(message);
                    return RedirectToAction(nameof(Login));
                }
                //foreach (var message in result.Messages) Notyf.Error(message);
            }
            return View(command);
        }
    }
}
