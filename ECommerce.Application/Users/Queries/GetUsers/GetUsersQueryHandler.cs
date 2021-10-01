using ECommerce.Application.Users.Dto;
using MediatR;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Users.Queries.GetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, ResponseState<List<UserDto>>>
    {
        private readonly IUserService _userService;

        public GetUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<ResponseState<List<UserDto>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {            
            return  new ResponseState<List<UserDto>>() { Content = await _userService.GetAllAsync()};
        }
    }
}
