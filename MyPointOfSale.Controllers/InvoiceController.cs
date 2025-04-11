using MyPointOfSale.Common.Cache;
using MyPointOfSale.DataAccessSQLServer;
using MyPointOfSale.Models;
using MyPointOfSale.ViewModels;
using MyPointOfSale.ViewModels.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPointOfSale.Controllers
{
    public class InvoiceController
    {
        private readonly InvoiceDao _invoiceDao;

        private Invoice _invoice;

        public InvoiceController()
        {
            _invoiceDao = new InvoiceDao();
        }
        public string GetNCF()
        {
            return _invoice.NCF;
        }

        public List<ProductLineViewModel> GetProductLineViewModel()
        {
            List<ProductLineViewModel> productLineViewModels = new List<ProductLineViewModel>();
            foreach (InvoiceLine item in _invoice.InvoiceLines)
            {
                productLineViewModels.Add(new ProductLineViewModel
                {
                    Description = item.Description,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ITBIS = item.ITBIS,
                    SubToal = item.SubTotal
                });
            }

            return productLineViewModels;
        }

        public IReadOnlyList<ProductViewModel> GetProducts()
        {
            return new ProductController().GetProducts();
        }

        public IReadOnlyList<ClientViewModel> GetClients()
        {
            IReadOnlyList<Client> clients = _invoiceDao.GetClients();
            if (clients == null)
            {
                throw new InvalidOperationException("No se encontraron clientes");
            }

            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            foreach (Client client in clients)
            {
                clientViewModels.Add(new ClientViewModel()
                {
                    ClientId = client.ClientId,
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    DocumentId = client.DocumentType.DocumentID,
                    DocumentName = client.DocumentType.DocumentName,
                    DocumentNumber = client.DocumentNumber
                });
            }

            return clientViewModels;
        }

        public decimal GetSubTotal()
        {
            if (_invoice == null)
            {
                throw new ArgumentException("No se ha iniciado una venta");
            }
            return _invoice.GetSubTotal;
        }

        public decimal GetTotal()
        {
            if (_invoice == null)
            {
                throw new ArgumentException("No se ha iniciado una venta");
            }

            return _invoice.GetTotal;
        }

        public decimal GetITBIS()
        {
            if (_invoice == null)
            {
                throw new ArgumentException("No se ha iniciado una venta");
            }

            return _invoice.GetITBIS;
        }

        public void StartNewSale()
        {
            _invoice = new Invoice();
            AddUser();
        }

        public void AddUser()
        {
            User user = new UserDao().GetUsers().FirstOrDefault(u => u.UserId == UserLoginCache.UserId);
            if (user == null)
            {
                throw new ArgumentException("El usuario no existe");
            }

            _invoice.User = user;
        }

        public void AddClient(string document)
        {
            Client client = _invoiceDao.GetClientBy(document);
            if (client == null)
            {
                throw new ArgumentException("El cliente no existe");
            }

            _invoice.Client = client;
        }

        public void AddLineOFProduct(LineOfProductViewModel lineOfProductViewModel)
        {
            if (lineOfProductViewModel == null)
            {
                throw new ArgumentException("La línea de producto no puede ser nula");
            }

            _invoice.AddLine(new InvoiceLine()
            {
                ProductId = lineOfProductViewModel.ProductId,
                Description = lineOfProductViewModel.Description,
                Price = lineOfProductViewModel.Price,
                Quantity = lineOfProductViewModel.Quantity
            });
        }

        public void GenerateNCF()
        {
            (int, string) result = _invoiceDao.GetNCF();
            _invoice.NCFID = result.Item1;
            _invoice.NCF = result.Item2;

        }

        public void EndSale()
        {
            _invoice.EndSale();
        }

        public void ProccessInvoice()
        {

            _invoiceDao.ProcessInvoice(_invoice);
        }

        public decimal CalculateSalesTotal()
        {
            decimal total = default;
            IReadOnlyList<decimal> sales = _invoiceDao.GetSales();

            if (sales != null)
            {
                foreach (decimal saleTotal in sales)
                {
                    total += saleTotal;
                }
            }

            return total;
        }

        public int CountClients()
        {
            return _invoiceDao.GetClients().Count();
        }

        public int CountProducts()
        {
            return _invoiceDao.GetProducts().Count();
        }

        public int CountNcfUsed()
        {
            return _invoiceDao.CountNCFs();
        }
    }
}
