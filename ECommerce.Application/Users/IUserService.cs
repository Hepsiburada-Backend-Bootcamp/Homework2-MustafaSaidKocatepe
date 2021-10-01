using ECommerce.Application.Users.Commands.CreateUser;
using ECommerce.Application.Users.Commands.DeleteUser;
using ECommerce.Application.Users.Commands.UpdateUser;
using ECommerce.Application.Users.Commands.UpdateUserEmail;
using ECommerce.Application.Users.Dto;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Users
{
    public interface IUserService
    {
       Task<UserDto> CreateAsync(CreateUserCommand request);
        Task<ResponseState<UserDto>> GetByIdAsync(int id);
        Task<List<UserDto>> GetAllAsync();
        Task<bool> DeleteAsync(DeleteUserCommand request);
        Task<bool> UpdateAsync(UpdateUserCommand request);
        Task<bool> UpdateUserEmailAsync(UpdateUserEmailCommand request);
    }
}
