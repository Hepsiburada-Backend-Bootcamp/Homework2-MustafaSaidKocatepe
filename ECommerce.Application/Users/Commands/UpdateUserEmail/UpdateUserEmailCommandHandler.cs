using MediatR;
using ResponseStates.Enums;
using ResponseStates.Exceptions;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Users.Commands.UpdateUserEmail
{
    public class UpdateUserEmailCommandHandler : IRequestHandler<UpdateUserEmailCommand, ResponseState>
    {
        private readonly IUserService _userService;
        public UpdateUserEmailCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseState> Handle(UpdateUserEmailCommand request, CancellationToken cancellationToken)
        {
            if (!await _userService.UpdateUserEmailAsync(request))
            {
                throw new StateException { StateCode = StateCode.UnexpectedError }; //TO DO: 
            }
            return new ResponseState(StateCode.UserEmailUpdate);
        }
    }
}
