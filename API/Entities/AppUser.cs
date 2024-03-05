namespace API.Entities
{
    public class AppUserOld
    {
        public int Id { get; set; }
        public string UserName { get; set; }

    }

    public record AppUser(int Id, string UserName)
    {
    }
}