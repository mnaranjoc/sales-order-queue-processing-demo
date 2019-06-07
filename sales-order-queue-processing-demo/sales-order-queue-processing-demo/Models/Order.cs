using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sales_order_queue_processing_demo.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        public string CustomerId { get; set; }

        public string DateCreated { get; set; }

        public string Status { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}