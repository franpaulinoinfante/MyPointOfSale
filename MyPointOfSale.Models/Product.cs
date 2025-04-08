namespace MyPointOfSale.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ITBIS { get; set; }
        public ProductCategory Category { get; set; }
    }
}