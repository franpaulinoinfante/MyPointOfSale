﻿namespace MyPointOfSale.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ITBIS { get; set; }
        public Category Category { get; set; }
    }
}