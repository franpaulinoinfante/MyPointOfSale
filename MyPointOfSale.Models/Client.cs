using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointOfSale.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
    }
}

/*
 [dbo].[Clients]
           ([FirstName]
           ,[LastName]
           ,[Email]
           ,[DocumentId]
           ,[DucmentNumber])
 
 */
