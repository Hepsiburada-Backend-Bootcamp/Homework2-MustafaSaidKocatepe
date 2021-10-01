using ECommerce.Application.Users.Dto;
using MediatR;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Users.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<ResponseState<UserDto>>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
