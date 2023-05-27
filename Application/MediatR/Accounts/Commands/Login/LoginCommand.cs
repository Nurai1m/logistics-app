using Application.Common.Models;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace Application.MediatR.Accounts.Commands
{
    public class LoginCommand : IRequest<Result>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LoginCommandHandler> _logger;

        public LoginCommandHandler(UserManager<User> userManager,
                                   SignInManager<User> signInManager,
                                   ILogger<LoginCommandHandler> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<Result> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(request.Username, request.Password, false, true);

            return result switch
            {
                { Succeeded: true } => Result.Success(),
                _ => Result.Failure("Неправильный логин или пароль.")
            };
        }

        private async Task SignInWithClaimsAsync(User user, UserShop userShop)
        {
            IList<Claim> claims = new List<Claim>();
            claims.Add(new Claim("Fullname", user.Fullname));

            await _signInManager.SignInWithClaimsAsync(user, true, claims);
        }
    }
}