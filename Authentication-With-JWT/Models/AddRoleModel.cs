using System.ComponentModel.DataAnnotations;

namespace Authentication_With_JWT.Models
{
    public class AddRoleModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Userid { get; set; }
        
    }
}
