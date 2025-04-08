using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class InvoiceDao : ConnectionToSQLServer
    {
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
