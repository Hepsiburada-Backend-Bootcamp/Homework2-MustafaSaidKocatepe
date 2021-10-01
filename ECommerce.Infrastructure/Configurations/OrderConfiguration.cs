using ECommerce.Domain.Entities;
using ECommerce.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //builder.ToTable("orders");
            builder.HasKey(t => t.Id).HasName("order_id");
            builder.Property(t => t.UserId).HasColumnName("user_id").IsRequired();
            builder.Property(t => t.OrderNumber).HasColumnName("order_number").IsRequired();
            builder.Property(t => t.OrderDate).HasColumnName("order_date").HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(t => t.OrderStatus).HasColumnName("order_status").IsRequired();
            builder.Property(t => t.PaymentType).HasColumnName("payment_type").IsRequired();
            builder.HasData(Data());
        }
        IEnumerable<Order> Data()
        {
            return new List<Order>
            {
              new Order  {
                 Id         = 1,
                 UserId       = 1,
                 OrderDate    = DateTime.Now,
                 OrderNumber    = "67854",
                 OrderStatus      = OrderStatus.Approved,
                 PaymentType  = PaymentType.Online
                },
              new Order  {
                 Id         = 2,
                 UserId       = 1,
                 OrderDate    = DateTime.Now,
                 OrderNumber    = "84768",
                 OrderStatus      = OrderStatus.Delivered,
                 PaymentType  = PaymentType.CashOnDelivery
                }
            };
        }
    }
}
