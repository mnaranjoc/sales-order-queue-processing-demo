namespace sales_order_queue_processing_demo.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }

        public double Qty { get; set; }

        public string ProductID { get; set; }

        public double UnitPrice { get; set; }

        public double LineAmount { get; set; }
    }
}