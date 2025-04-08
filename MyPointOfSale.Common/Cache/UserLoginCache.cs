namespace MyPointOfSale.Common.Cache
{
    public static class UserLoginCache
    {
        public static int UserId { get; set; } = 0;
        public static string FirstName { get; set; } = string.Empty;
        public static string LastName { get; set; } = string.Empty;
        public static string Position { get; set; } = string.Empty;
        public static string Email { get; set; } = string.Empty;

    }
}
