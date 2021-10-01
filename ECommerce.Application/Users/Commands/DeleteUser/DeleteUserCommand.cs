using MediatR;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<ResponseState>
    {
        public DeleteUserCommand(long id)
        {
            Id = id;  
        }
        public long Id { get; set; }
    }
}
