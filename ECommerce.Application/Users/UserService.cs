using AutoMapper;
using Dapper;
using ECommerce.Application.Users.Commands.CreateUser;
using ECommerce.Application.Users.Commands.DeleteUser;
using ECommerce.Application.Users.Commands.UpdateUser;
using ECommerce.Application.Users.Commands.UpdateUserEmail;
using ECommerce.Application.Users.Dto;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Repositories;
using Microsoft.Extensions.Configuration;
using Npgsql;
using ResponseStates.Enums;
using ResponseStates.Exceptions;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserService(IMapper mapper, IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<User> Detail(long id)
        {
            var user = await _userRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                throw new StateException { StateCode = StateCode.NotFoundUser };
            }
            else if (!user.IsActive)
            {
                throw new StateException { StateCode = StateCode.InActiveUser };
            }

            return user;
        }
        public async Task<UserDto> CreateAsync(CreateUserCommand request)
        {
            //var user = new User { Name = request.Name, Surname = request.Surname,Email= request.Email, Telephone = request.Telephone};

            var user = _mapper.Map<User>(request);
            await _userRepository.AddAsync(user);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<ResponseState<UserDto>> GetByIdAsync(int id)
        {
            var user = await Detail(id);
            return new ResponseState<UserDto>() { Content = _mapper.Map<UserDto>(user) };
        }

        public static IDbConnection OpenConnection(string connectionString)
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            var result = new List<User>();

            using (var conn = OpenConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = conn.Query<User>("SELECT * FROM public.users").ToList();
            }

            return await Task.FromResult(_mapper.Map<List<User>, List<UserDto>>(result));
        }

        public async Task<bool> DeleteAsync(DeleteUserCommand request)
        {
            var user = await Detail(request.Id);
            _userRepository.Remove(user);
            return true;
        }

        public async Task<bool> UpdateAsync(UpdateUserCommand request)
        {
            var user = await Detail(request.Id);

            if (!string.IsNullOrWhiteSpace(request.User.Name))
                user.Name = request.User.Name;
            if (!string.IsNullOrWhiteSpace(request.User.Surname))
                user.Surname = request.User.Surname;
            if (!string.IsNullOrWhiteSpace(request.User.Email))
                user.Email = request.User.Email;
            if (!string.IsNullOrWhiteSpace(request.User.Telephone))
                user.Telephone = request.User.Telephone;

            _userRepository.Update(user);
            return true;
        }


        public async Task<bool> UpdateUserEmailAsync(UpdateUserEmailCommand request)
        {
            var user = await Detail(request.Id);

            //if (!string.IsNullOrWhiteSpace(request.User.Email))
            user.Email = request.UserEmail.Email;

            _userRepository.Update(user); // TO DO 
            return true;
        }

    }
}
