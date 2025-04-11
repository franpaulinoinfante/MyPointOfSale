namespace MyPointOfSale.ViewModels.Invoice
{
    public class LineOfProductViewModel
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public object ProductId { get; set; }
    }
}
