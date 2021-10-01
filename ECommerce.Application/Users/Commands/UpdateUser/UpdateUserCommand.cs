using ECommerce.Application.Users.Dto;
using MediatR;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<ResponseState>
    {
        public UpdateUserCommand(long id, UpdateUserDto user)
        {
            Id = id;
            User = user;
        }
        public long Id { get; }
        public UpdateUserDto User { get; }
    }
}
