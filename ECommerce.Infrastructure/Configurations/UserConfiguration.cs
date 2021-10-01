using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Data.Mappings
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //fluent api
            //builder.ToTable("users");
            builder.HasKey(t => t.Id).HasName("user_id");
            builder.Property(t => t.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(t => t.Surname).HasColumnName("surname").HasMaxLength(100).IsRequired();
            builder.Property(t => t.Email).HasColumnName("email").IsRequired();
            builder.Property(t => t.Telephone).HasColumnName("telephone").IsRequired();
            builder.Property(t => t.CreatedDate).HasColumnName("created_date").HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(t => t.IsActive).HasColumnName("is_active").HasDefaultValue(true).IsRequired();
            builder.HasData(Data());
        }
        IEnumerable<User> Data()
        {
            return new List<User>
            {
              new User  {
                 Id         = 1,
                 Name       = "Mustafa Said",
                 Surname    = "Kocatepe",
                 Email      = "msaidkocatepe@gmail.com",
                 Telephone  = "05398882132",
                 CreatedDate= DateTime.Now,
                 IsActive    =true
                },
                new User
                {
                Id= 2,
                Name        = "Ömer",
                Surname     = "Baldan",
                Email       = "omerbaldan@gmail.com",
                Telephone   = "05398882132",
                CreatedDate = DateTime.Now.AddDays(-1),
                IsActive    = true
                }
            };
        }

    }
}
