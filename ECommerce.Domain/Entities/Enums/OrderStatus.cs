using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Domain.Entities.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "Hazırlanıyor")]
        Approved = 1,
        [Display(Name = "Kargoya verildi")]
        Shipment = 2,
        [Display(Name = "Teslim edildi")]
        Delivered = 3,
    }
}
