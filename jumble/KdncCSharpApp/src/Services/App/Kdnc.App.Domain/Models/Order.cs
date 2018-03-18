using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kdnc.App.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public ICollection<OrderItem> Items { get; set; }
    }
}
