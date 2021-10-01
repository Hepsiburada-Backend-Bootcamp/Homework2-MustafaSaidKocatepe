using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Domain.Entities
{
    [Table("products", Schema = "public")]
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
