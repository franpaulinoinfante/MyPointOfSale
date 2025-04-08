namespace MyPointOfSale.ViewModels
{
    public class UsuarioCreateViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DocumentTypeId { get; set; }
        public int PositionId { get; set; }
        public string DocumentNumber { get; set; }
    }
}
