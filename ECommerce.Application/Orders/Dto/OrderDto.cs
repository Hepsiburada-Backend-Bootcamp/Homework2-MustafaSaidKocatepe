using ECommerce.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Orders.Dto
{
    public class OrderDto
    {
        public long Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
