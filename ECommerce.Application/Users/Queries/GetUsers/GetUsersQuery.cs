using ECommerce.Application.Users.Dto;
using MediatR;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Users.Queries.GetUsers
{
    public class GetUsersQuery : IRequest<ResponseState<List<UserDto>>>
    {
    }
}
