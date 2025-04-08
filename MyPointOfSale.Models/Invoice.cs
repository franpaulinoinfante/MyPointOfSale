using System;
using System.Collections.Generic;

namespace MyPointOfSale.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public User User { get; set; }
        public Client Client { get; set; }
        public string NCF { get; set; }
        public DateTime CreateAt { get; set; }
        public decimal Total { get; set; }
        public decimal ITBIS { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();
    }
}