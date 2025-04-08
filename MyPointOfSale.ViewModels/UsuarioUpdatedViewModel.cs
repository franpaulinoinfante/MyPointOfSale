using MyPointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointOfSale.ViewModels
{
    public class UsuarioUpdatedViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public int PositionId { get; set; }
    }
}
