using ECommerce.Application.Users.Dto;
using MediatR;
using ResponseStates.Enums;
using ResponseStates.Exceptions;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResponseState>
    {
        private readonly IUserService _userService;
        public UpdateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseState> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if (!await _userService.UpdateAsync(request))
            {
                throw new StateException { StateCode = StateCode.UnexpectedError }; //TO DO: 
            }

            return new ResponseState(StateCode.UserUpdate);
        }
    }
}
