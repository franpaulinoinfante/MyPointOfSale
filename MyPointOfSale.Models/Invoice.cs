using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointOfSale.Models
{
    public class Invoice 
    {
        public int InvoiceId { get; set; }
        public Client Client { get; set; }
        public DateTime CreateAt { get; set; }
        public decimal Total { get; set; }
        public decimal ITBIS { get; set; }
        public User User { get; set; }
        public string NCF { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();
    }
}

/*
 [InvoiceId]
      ,[CreateAt]
      ,[ClientId]
      ,[Total]
      ,[ITBIS]
      ,[UserId]
      ,[NCF]

*/