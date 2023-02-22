using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Dto.User
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Password should be between {1} and {2} characters", MinimumLength = 7)]
        public string Password { get; set; }
    }
}
