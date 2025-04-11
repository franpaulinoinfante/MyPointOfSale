namespace MyPointOfSale.Models
{
    public class InvoiceLine
    {
        public object ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal ITBIS => Price * Quantity * 0.18m;
        public decimal SubTotal => Price * Quantity;

    }
}
