namespace Authentication_With_JWT.Models
{
    public class AppUser : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
