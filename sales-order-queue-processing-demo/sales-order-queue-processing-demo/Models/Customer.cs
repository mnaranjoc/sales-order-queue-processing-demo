using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sales_order_queue_processing_demo.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        public Boolean Blocked { get; set; }
    }
}