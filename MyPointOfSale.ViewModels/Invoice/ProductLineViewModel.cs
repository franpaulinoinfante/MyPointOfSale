namespace MyPointOfSale.ViewModels.Invoice
{
    public class ProductLineViewModel
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal ITBIS { get; set; }
        public decimal SubToal { get; set; }
    }
}
