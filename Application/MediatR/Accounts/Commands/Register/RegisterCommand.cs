using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Accounts.Commands
{
    public class RegisterCommand : IRequest<Result>
    {
        public string Firstname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Guid RoleId { get; set; }
    }

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ILogisticEFContext _context;
        private readonly ILogger<RegisterCommandHandler> _logger;

        public RegisterCommandHandler(UserManager<User> userManager,
                RoleManager<Role> roleManager,
                                      ILogisticEFContext context,
                                      ILogger<RegisterCommandHandler> logger)
        {
            _userManager = userManager;
            _context = context;
            _logger = logger;
            _roleManager = roleManager;
        }

        public async Task<Result> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = new User();
                var existingUser = await _userManager.FindByLoginAsync(request.Username, request.Password);

                if (existingUser != null)
                {
                    return Result.Failure($"Пользователь с таким логином {request.Username} уже существует.");
                }

                if (request.Password != request.ConfirmPassword)
                {
                    return Result.Failure($"Пароли не совпадают.");
                }

                user.Name = request.Name;
                user.Firstname = request.Firstname;
                user.Patronymic = request.Patronymic;
                user.Address = request.Patronymic;
                user.DateOfBirth = request.DateOfBirth;
                user.UserName = request.Username;

                var result = await _userManager.CreateAsync(user, request.Password);

                var roles = _roleManager.Roles.Where(x => x.Id == request.RoleId).Select(x=>x.Name).ToList();

                await _userManager.AddToRolesAsync(user, (IEnumerable<string>)roles);

                return Result.Success("Вы успешно зарегистрированы. Ожидайте подтверждения аккаунта.");

            }
            catch (Exception ex)
            {
                return Result.Failure($"Возникли ошибки.");
            }
        }
    }
}
