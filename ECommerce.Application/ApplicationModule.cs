using ECommerce.Application.Orders;
using ECommerce.Application.Users;
using ECommerce.Domain.Repositories;
using ECommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            //services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddAutoMapper(typeof(UserMappingProfile));
            services.AddAutoMapper(typeof(OrderMappingProfile));

            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IOrderService, OrderService>();          

            return services;
        }
    }
}
