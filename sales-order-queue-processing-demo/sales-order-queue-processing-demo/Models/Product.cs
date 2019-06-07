using System.ComponentModel.DataAnnotations;

namespace sales_order_queue_processing_demo.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}