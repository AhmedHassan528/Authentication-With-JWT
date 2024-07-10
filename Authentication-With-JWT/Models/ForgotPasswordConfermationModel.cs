using System.ComponentModel.DataAnnotations;

namespace Authentication_With_JWT.Models
{
    public class ForgotPasswordConfermationModel
    {
        [Required]
        public string token { get; set; }
        [Required]
        public string userId { get; set; }
        [Required]
        public string newPassword { get; set; }
        [Required]
        public string confirmPassword { get; set; }
    }
}
