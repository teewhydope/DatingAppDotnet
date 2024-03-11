namespace API.Entities
{
    public class AppUserOld
    {
        public int Id { get; set; }
        public string UserName { get; set; }

    }

    public record AppUser
    {

        public int Id { get; init; }
        public required string Username { get; init; }
        public required byte[] PasswordHash { get; init; }
        public required byte[] PasswordSalt { get; init; }

    }
}