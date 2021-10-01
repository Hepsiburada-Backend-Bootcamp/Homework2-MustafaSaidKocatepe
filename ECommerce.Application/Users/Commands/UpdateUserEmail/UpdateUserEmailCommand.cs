using ECommerce.Application.Users.Dto;
using MediatR;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Users.Commands.UpdateUserEmail
{
    public class UpdateUserEmailCommand : IRequest<ResponseState>
    {
        public UpdateUserEmailCommand(long id, UpdateUserEmailDto userEmail )
        {
            Id = id;
            UserEmail = userEmail;
        }
        public long Id { get; }
        public UpdateUserEmailDto UserEmail { get; }
    }
}
