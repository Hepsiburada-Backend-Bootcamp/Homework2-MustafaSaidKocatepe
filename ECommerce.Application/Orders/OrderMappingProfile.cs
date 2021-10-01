using AutoMapper;
using ECommerce.Application.Orders.Dto;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Orders
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            //CreateMap<CreateOrderCommand, Order>().ReverseMap();
        }
    }
}
