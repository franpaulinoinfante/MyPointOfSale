using System;
using System.Collections.Generic;

namespace MyPointOfSale.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int NCFID { get; set; }
        public string NCF { get; set; }
        public DateTime CreateAt { get; set; }
        public User User { get; set; }
        public Client Client { get; set; }
        public decimal Total { get; set; }
        public decimal ITBIS { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();

        public decimal GetSubTotal => CalculateTotal() - CalculateITBIS();

        public decimal GetITBIS => CalculateITBIS();

        public decimal GetTotal => CalculateTotal();

        public void AddLine(InvoiceLine line)
        {
            if (line == null)
            {
                throw new ArgumentException("La línea no puede ser nula");
            }

            if (line.Quantity <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero");
            }

            if (line.Price <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor que cero");
            }

            if (line.ITBIS < 0)
            {
                throw new ArgumentException("El ITBIS no puede ser negativo");
            }

            InvoiceLine invoiceLine = InvoiceLines.Find(l => l.Description == line.Description);
            if (!(invoiceLine == null))
            {
                invoiceLine.Quantity += line.Quantity;
                return;

            }

            InvoiceLines.Add(line);
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (InvoiceLine line in InvoiceLines)
            {
                total += line.SubTotal;
            }

            return total + CalculateITBIS();
        }

        private decimal CalculateITBIS()
        {
            decimal itbis = 0;
            foreach (InvoiceLine line in InvoiceLines)
            {
                itbis += line.ITBIS;
            }
            return itbis;
        }

        public void ProccessBill()
        {
            CreateAt = DateTime.Now;
        }

        public void EndSale()
        {
            throw new NotImplementedException();
        }
    }
}